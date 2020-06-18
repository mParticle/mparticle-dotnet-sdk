using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using mParticle.Client;
using mParticle.Model;

namespace mParticle.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMParticle
    {
        /// <summary>
        /// Enqueues an BaseEvent to be uploaded at the end of an `EventsApi#Configuration#UploadInterval` interval
        /// </summary>
        /// <param name="baseEvent">The BaseEvent to be enqueued</param>
        void LogEvent(BaseEvent baseEvent);

        /// <summary>
        /// Forces the upload of all events in the queue
        /// </summary>
        void Upload();

         /// <summary>
        /// Get or Set the BaseBatch instance which will be used for uploading enqueued events
        /// logged via EventsApi#LogEvent
        /// </summary>
        BaseBatch BaseBatch { get; set; }

        /// <summary>
        /// Get the configuration object
        /// </summary>
        IReadableConfiguration Configuration { get; }

        #region Synchronous Operations
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        ApiResponse<Object> BulkUploadBatches(Collection<Batch> batch);

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        ApiResponse<Object> UploadBatch(Batch batch);
        #endregion Synchronous Operations

        #region Asynchronous Operations
        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        Task<ApiResponse<Object>> BulkUploadBatchesAsync(Collection<Batch> batch);

        /// <summary>
        /// Send events to mParticle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mParticle.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        Task<ApiResponse<Object>> UploadBatchAsync(Batch batch);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MParticle : IMParticle
    {
        private static object syncLock = new object();

        private ApiClient _apiClient;
        private UploadQueue _uploadQueue;

        /// <summary>
        /// Get or Set the MParticle instance
        /// </summary>
        public static MParticle Instance { get; set; }

        private static LogLevel _logLevel = LogLevel.Verbose;
        
        /// <summary>
        /// Get or Set the log severity filter level
        /// </summary>
        public static LogLevel LogLevel 
        {
            get
            {
                return _logLevel;
            }

            set
            {
                _logLevel = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MParticle"/> class
        /// using a <see cref="Configuration"/> instance
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public static MParticle Start(Configuration configuration)
        {
            lock (syncLock)
            {
                if (Instance == null)
                {
                    if (string.IsNullOrEmpty(configuration.ApiKey))
                    {
                        throw new ArgumentException("ApiKey cannot be empty");
                    }
                    if (string.IsNullOrEmpty(configuration.ApiSecret))
                    {  
                        throw new ArgumentException("ApiSecret cannot be empty");
                    }
                    Instance = new MParticle(configuration);
                }
            }
            return Instance;
        }

        
        internal MParticle(Configuration configuration)
        {
            Configuration = new Configuration(configuration);
            _apiClient = new ApiClient(Configuration);
            _uploadQueue = new UploadQueue(this);
            _uploadQueue.StartUploadLoop();
        }

        /// <summary>
        /// Get the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration 
        {
            get;
            private set;
        }

        /// <summary>
        /// Get or Set the BaseBatch instance which will be used for uploading enqueued events
        /// logged via EventsApi#LogEvent
        /// </summary>
        public BaseBatch BaseBatch
        {
            get
            {
                return _uploadQueue.BaseBatch;
            }
            set
            {
                _uploadQueue.BaseBatch = value;
            }
        }

        /// <summary>
        /// Enqueues an BaseEvent to be uploaded at the end of an `EventsApi#Configuration#UploadInterval` interval
        /// </summary>
        /// <param name="baseEvent">The BaseEvent to be enqueued</param>
        public void LogEvent(BaseEvent baseEvent)
        {
            if (baseEvent.TimestampUnixtimeMs == 0)
            {
                baseEvent.TimestampUnixtimeMs = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds();
            }
            _uploadQueue.AddEvent(baseEvent);
        }

        /// <summary>
        /// Forces the upload of all events in the queue
        /// </summary>
        public void Upload()
        {
            _uploadQueue.ForceUpload();
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns></returns>
        public ApiResponse<Object> UploadBatch(Batch batch)
        {
            Logger.Verbose("Uploading Batch");
            RequestOptions localVarRequestOptions = new RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            batch.ApiKey = Configuration.ApiKey;
            localVarRequestOptions.Data = batch;

            // make the HTTP request
            var localVarResponse = _apiClient.Post<Object>("/events", localVarRequestOptions);
            return localVarResponse;
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batch"> (optional)</param>
        /// <returns>Task of void</returns>
        public async Task<ApiResponse<object>> UploadBatchAsync(Batch batch)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

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

            batch.ApiKey = Configuration.ApiKey;
            localVarRequestOptions.Data = batch;


            // make the HTTP request
            var localVarResponse = await _apiClient.PostAsync<Object>("/events", localVarRequestOptions);
            return localVarResponse;
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="mParticle.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batches">The Batches to be uploaded</param>
        /// <returns></returns>
        public ApiResponse<Object> BulkUploadBatches(Collection<Batch> batches)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            Logger.Verbose("Setting Batchs ApiKey: " + Configuration.ApiKey);

            foreach (Batch batch in batches)
            {
                batch.ApiKey = Configuration.ApiKey;
            }

            localVarRequestOptions.Data = batches;


            // make the HTTP request
            return _apiClient.Post<Object>("/bulkevents", localVarRequestOptions);
        }

        /// <summary>
        /// Send events to mParticle 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="batches">The batches to be uploaded</param>
        /// <returns>Task of void</returns>
        public async Task<ApiResponse<Object>> BulkUploadBatchesAsync(Collection<Batch> batches)
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

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

            Logger.Verbose("Setting Batchs ApiKey: " + Configuration.ApiKey);

            foreach (Batch batch in batches)
            {
                batch.ApiKey = Configuration.ApiKey;
            }

            localVarRequestOptions.Data = batches;


            // make the HTTP request

            var localVarResponse = await this._apiClient.PostAsync<Object>("/bulkevents", localVarRequestOptions);

            return localVarResponse;
        }

    }
}
