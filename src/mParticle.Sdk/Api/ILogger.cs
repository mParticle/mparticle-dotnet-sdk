using System;
namespace mParticle.Api
{
    /// <summary>
    /// Log handler interface for processing internal logs
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Handle a logging message of priority Verbose
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void Verbose(string message);

        /// <summary>
        /// Handle a logging message of priority Warning
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void Warning(string message);

        /// <summary>
        /// Handle a logging message of priority Error
        /// </summary>
        /// <param name="message">The message to be logged</param>
        void Error(string message);
    }

    /// <summary>
    /// Log manager. Contains a settable static instance of the current ILogger log handler implementation
    /// </summary>
    public class Logger
    {
        private static ILogger _logger = new DefaultLogger();

        /// <summary>
        /// Register an instance of <see cref="ILogger"/> to handle logging calls.
        /// The instance you register will be the sole log handler, so default Logging
        /// behavior will cease. To revert back to the Default Logger, set this property to null
        /// </summary>
        public static ILogger Instance
        {
            get
            {
                return _logger;
            }
            set
            {
                if (value == null) {
                    _logger = new DefaultLogger();
                }
                else
                {
                    _logger = value;
                }
            }
        }

        internal static void Verbose(string message)
        {
            if ((int)MParticle.LogLevel >= (int)LogLevel.Verbose)
            {
                Instance.Verbose(message);
            }
        }

        internal static void Warning(string message)
        {
            if ((int)MParticle.LogLevel >= (int)LogLevel.Warning)
            {
                Instance.Warning(message);
            }
        }

        internal static void Error(string message)
        {
            if ((int)MParticle.LogLevel >= (int)LogLevel.Error)
            {
                Instance.Warning(message);
            }
        }
    }

    internal class DefaultLogger: ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine("MParticle Error: " + message);
        }

        public void Verbose(string message)
        {
            Console.WriteLine("MParticle Verbose: " + message);
        }

        public void Warning(string message)
        {
            Console.WriteLine("MParticle Warning: " + message);
        }
    }

    /// <summary>
    /// Enumeration of logging severity levels for the purpose of filtering log output
    /// </summary>
    public enum LogLevel
    {
        /// <summary>Verbose, Warning or Error log level</summary>
        Verbose = 1,

        /// <summary>Warning or Error log level</summary>
        Warning = 2,
        /// <summary>Error log level</summary>
        Error = 3
    }
}
