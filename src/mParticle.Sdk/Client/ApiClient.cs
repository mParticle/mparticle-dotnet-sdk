using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Net;
using RestSharp;
using RestSharp.Deserializers;
using RestSharpMethod = RestSharp.Method;
using mParticle.Api;
using System.Text;

namespace mParticle.Client
{

    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementatios),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    internal partial class ApiClient : ISynchronousClient, IAsynchronousClient
    {
        internal readonly IReadableConfiguration configuration;

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        void InterceptRequest(IRestRequest request)
        {
            var builder = new StringBuilder()
                .AppendLine("Starting Request")
                .AppendLine("\tType: " + request.Method.ToString())
                .AppendLine("\tUrl: " + request.Resource);
            if (request.Method == RestSharpMethod.POST)
            {
                builder.AppendLine("\tBody:\n" + request.JsonSerializer.Serialize(request.Parameters.Last().Value).ToPrettyJson(1));
            }
            Logger.Verbose(builder.ToString());
        }

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        void InterceptResponse(IRestRequest request, IRestResponse response)
        {
            var builder = new StringBuilder()
                .AppendLine("Finished Request")
                .AppendLine("\tCode: " + response.StatusCode);
            if (response.ErrorMessage != null && response.ErrorMessage.Length > 0)
            {
                builder.AppendLine("\tError: " + response.ErrorMessage);
            }
            if (response.Content != null && response.Content.Length > 0)
            {
                builder.AppendLine("\tMessage:\n" + response.Content.ToPrettyJson(1));
            }
            Logger.Verbose(builder.ToString());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" />
        /// </summary>
        /// <param name="config">The Configuration object</param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(IReadableConfiguration config)
        {
            configuration = config;
            Logger.Verbose("started");
        }

        /// <summary>
        /// Constructs the RestSharp version of an http method
        /// </summary>
        /// <param name="method">Swagger Client Custom HttpMethod</param>
        /// <returns>RestSharp's HttpMethod instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private RestSharpMethod Method(HttpMethod method)
        {
            RestSharpMethod other;
            switch (method)
            {
                case HttpMethod.Get:
                    other = RestSharpMethod.GET;
                    break;
                case HttpMethod.Post:
                    other = RestSharpMethod.POST;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("method", method, null);
            }

            return other;
        }

        /// <summary>
        /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the RestSharp request.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>[private] A new RestRequest instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private RestRequest NewRequest(
            HttpMethod method,
            String path,
            RequestOptions options)
        {
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");
            if (configuration == null) throw new ArgumentNullException("configuration");

            options.HeaderParameters.Add("Authorization", getBasicAuthorization(configuration.ApiKey, configuration.ApiSecret));

            RestRequest request = new RestRequest(Method(method))
            {
                Resource = path,
                JsonSerializer = new CustomJsonCodec(configuration)
            };

            if (options.PathParameters != null)
            {
                foreach (var pathParam in options.PathParameters)
                {
                    request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
                }
            }

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        request.AddQueryParameter(queryParam.Key, value);
                    }
                }
            }

            if (configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in configuration.DefaultHeaders)
                {
                    request.AddHeader(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        request.AddHeader(headerParam.Key, value);
                    }
                }
            }

            if (options.FormParameters != null)
            {
                foreach (var formParam in options.FormParameters)
                {
                    request.AddParameter(formParam.Key, formParam.Value);
                }
            }

            if (options.Data != null)
            {
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(options.Data);
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    var bytes = ClientUtils.ReadAsBytes(fileParam.Value);
                    var fileStream = fileParam.Value as FileStream;
                    if (fileStream != null)
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, System.IO.Path.GetFileName(fileStream.Name)));
                    else
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, "no_file_name_provided"));
                }
            }

            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                foreach (var cookie in options.Cookies)
                {
                    request.AddCookie(cookie.Name, cookie.Value);
                }
            }

            return request;
        }

        private ApiResponse<T> ToApiResponse<T>(IRestResponse<T> response)
        {
            T result = response.Data;
            string rawContent = response.Content;

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ErrorMessage,
                Cookies = new List<Cookie>()
            };

            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (response.Cookies != null)
            {
                foreach (var responseCookies in response.Cookies)
                {
                    transformed.Cookies.Add(
                        new Cookie(
                            responseCookies.Name,
                            responseCookies.Value,
                            responseCookies.Path,
                            responseCookies.Domain)
                        );
                }
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(RestRequest req, IReadableConfiguration configuration)
        {
            RestClient client = new RestClient(configuration.BasePath);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                foreach (var type in new String[] { "application/json", "text/json", "text/x-json", "text/javascript", "*+json" })
                {
                    client.AddHandler(type, () => existingDeserializer);
                }
            }
            else
            {
                foreach (var type in new String[] { "application/json", "text/json", "text/x-json", "text/javascript", "*+json" })
                {
                    client.AddHandler(type, () => new CustomJsonCodec(configuration));
                }
            }

            client.Timeout = configuration.Timeout;

            if (configuration.UserAgent != null)
            {
                client.UserAgent = configuration.UserAgent;
            }

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }


            InterceptRequest(req);

            var response = client.Execute<T>(req);

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(RestRequest req, IReadableConfiguration configuration)
        {
            RestClient client = new RestClient(configuration.BasePath);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                foreach (var type in new String[] { "application/json", "text/json", "text/x-json", "text/javascript", "*+json" })
                {
                    client.AddHandler(type, () => existingDeserializer);
                }
            }
            else
            {
                foreach (var type in new String[] { "application/json", "text/json", "text/x-json", "text/javascript", "*+json" })
                client.AddHandler(type, () => new CustomJsonCodec(configuration));
            }

            client.Timeout = configuration.Timeout;

            if (configuration.UserAgent != null)
            {
                client.UserAgent = configuration.UserAgent;
            }

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }

            InterceptRequest(req);

            var response = await client.ExecuteAsync<T>(req);

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        private string getBasicAuthorization(string userName, string password)
        {
            string usernameAndPassword = userName + ":" + password;
            byte[] bytes = Encoding.ASCII.GetBytes(usernameAndPassword);
            String encoded = Convert.ToBase64String(bytes);
            return "Basic " + encoded;
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options), configuration);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        ///<returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options)
        {
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options), configuration);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        ///<returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Get, path, options), configuration);
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        ///<returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options)
        {
            return Exec<T>(NewRequest(HttpMethod.Post, path, options), configuration);
        }
        #endregion ISynchronousClient
    }
}
