using System;
using System.Reflection;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using mParticle.Api;

namespace mParticle.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.3.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Private Members

        private string _basePath;
        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        #endregion Private Members

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "VirtualMemberCallInConstructor")]
        public Configuration(
            string apiKey,
            string apiSecret,
            string basePath = "https://s2s.mparticle.com/v2",
            int? uploadInterval = null,
            int? timeout = null,
            IDictionary<string, string> defaultHeaders = default(Dictionary<string, string>),
            string dateTimeFormat = default(string)
            )
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", "basePath");

            BasePath = basePath;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            if (uploadInterval != null)
            {
                UploadInterval = (int)uploadInterval;
            }
            if (timeout != null)
            {
                Timeout = (int)timeout;
            }
            DefaultHeaders = defaultHeaders;
            DateTimeFormat = dateTimeFormat;
        }

        internal Configuration(Configuration config)
        {
            ApiKey = config.ApiKey;
            ApiSecret = config.ApiSecret;
            DefaultHeaders = config.DefaultHeaders;
            BasePath = config.BasePath;
            Timeout = config.Timeout;
            UserAgent = config.UserAgent;
            DateTimeFormat = config.DateTimeFormat;
            UploadInterval = config.UploadInterval;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value> 
        public string ApiKey { get; }
        
        /// <summary>
        /// Gets the API secret.
        /// </summary>
        /// <value>API secret.</value>
        public string ApiSecret { get; }

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
        {
            get { return _basePath; }
            set
            {
                _basePath = value;
            }
        }

        
		private IDictionary<string, string> _defaultHeaders = new Dictionary<string, string>();
        /// <summary>
        /// Gets or sets the default headers.
        /// </summary>
        public virtual IDictionary<string, string> DefaultHeaders
        {
            get
            {
                return _defaultHeaders;
            }
            set
            {
                _defaultHeaders = value ?? new Dictionary<string, string>();
            }
        }

		private int _timeout = 10 * 1000;
        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 10 * 1000 milliseconds.
        /// </summary>
        public virtual int Timeout {
            get
            {
                return _timeout;
            }
            set
            {
                if (value > 0)
                {
                    _timeout = value;
                }
                else
                {
                    Logger.Warning("Timeout must be a positive number, unable to set value = " + value);
                }
            }
        }

        private int _uploadInterval = 60 * 1000;
        /// <summary>
        /// Gets or sets the Upload interval (milliseconds) of ApiClient. Default to 60 * 1000 milliseconds.
        /// </summary>
        public int UploadInterval
        {
            get
            {
                return _uploadInterval;
            }
            set
            {
                if (value > 0)
                {
                    _uploadInterval = value;
                }
                else
                {
                    Logger.Warning("UploadInterval must be a positive number, unable to set value = " + value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }


        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a string with essential information for debugging.
        /// </summary>
        public static String ToDebugReport()
        {
            String report = "C# SDK (mParticle.Sdk) Debug Report:\n";
            report += "    OS: " + System.Runtime.InteropServices.RuntimeInformation.OSDescription + "\n";
            report += "    Version of the API: 1.0.0\n";
            report += "    SDK Package Version: " + Version + "\n";

            return report;
        }


        #endregion Methods


    }
}
