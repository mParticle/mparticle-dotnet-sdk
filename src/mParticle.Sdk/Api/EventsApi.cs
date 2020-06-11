using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using mParticle.Sdk.Client;
using mParticle.Sdk.Model;

namespace mParticle.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        void BulkUploadEvents (Collection<Batch> batch = default(Collection<Batch>));

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> BulkUploadEventsWithHttpInfo (Collection<Batch> batch = default(Collection<Batch>));
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        void UploadEvents (Batch batch = default(Batch));

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UploadEventsWithHttpInfo (Batch batch = default(Batch));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task BulkUploadEventsAsync (Collection<Batch> batch = default(Collection<Batch>));

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> BulkUploadEventsAsyncWithHttpInfo (Collection<Batch> batch = default(Collection<Batch>));
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UploadEventsAsync (Batch batch = default(Batch));

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UploadEventsAsyncWithHttpInfo (Batch batch = default(Batch));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApi : IEventsApiSync, IEventsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventsApi : IEventsApi
    {
        private mParticle.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = mParticle.Sdk.Client.Configuration.MergeConfigurations(
                mParticle.Sdk.Client.GlobalConfiguration.Instance,
                new mParticle.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new mParticle.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mParticle.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = mParticle.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(mParticle.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = mParticle.Sdk.Client.Configuration.MergeConfigurations(
                mParticle.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new mParticle.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mParticle.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = mParticle.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EventsApi(mParticle.Sdk.Client.ISynchronousClient client,mParticle.Sdk.Client.IAsynchronousClient asyncClient, mParticle.Sdk.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = mParticle.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public mParticle.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public mParticle.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public mParticle.Sdk.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mParticle.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        public void BulkUploadEvents (Collection<Batch> batch = default(Collection<Batch>))
        {
             BulkUploadEventsWithHttpInfo(batch);
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public mParticle.Sdk.Client.ApiResponse<Object> BulkUploadEventsWithHttpInfo (Collection<Batch> batch = default(Collection<Batch>))
        {
            mParticle.Sdk.Client.RequestOptions localVarRequestOptions = new mParticle.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mParticle.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mParticle.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = batch;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/bulkevents", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUploadEvents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task BulkUploadEventsAsync (Collection<Batch> batch = default(Collection<Batch>))
        {
             await BulkUploadEventsAsyncWithHttpInfo(batch);

        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<mParticle.Sdk.Client.ApiResponse<Object>> BulkUploadEventsAsyncWithHttpInfo (Collection<Batch> batch = default(Collection<Batch>))
        {

            mParticle.Sdk.Client.RequestOptions localVarRequestOptions = new mParticle.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = batch;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/bulkevents", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUploadEvents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        public void UploadEvents (Batch batch = default(Batch))
        {
             UploadEventsWithHttpInfo(batch);
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public mParticle.Sdk.Client.ApiResponse<Object> UploadEventsWithHttpInfo (Batch batch = default(Batch))
        {
            mParticle.Sdk.Client.RequestOptions localVarRequestOptions = new mParticle.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mParticle.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mParticle.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = batch;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UploadEvents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UploadEventsAsync (Batch batch = default(Batch))
        {
             await UploadEventsAsyncWithHttpInfo(batch);

        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<mParticle.Sdk.Client.ApiResponse<Object>> UploadEventsAsyncWithHttpInfo (Batch batch = default(Batch))
        {

            mParticle.Sdk.Client.RequestOptions localVarRequestOptions = new mParticle.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = batch;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/events", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UploadEvents", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
