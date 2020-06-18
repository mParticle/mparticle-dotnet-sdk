using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace mParticle.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        string ApiKey { get; }

        /// <summary>
        /// Gets the API secret.
        /// </summary>
        /// <value>API secret.</value>
        string ApiSecret { get; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time foramt.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default headers.
        /// </summary>
        /// <value>Default headers.</value>
        IDictionary<string, string> DefaultHeaders { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int UploadInterval { get; }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>User agent.</value>
        string UserAgent { get; }

        /// <summary>
        /// Gets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        X509CertificateCollection ClientCertificates { get; }
    }
}
