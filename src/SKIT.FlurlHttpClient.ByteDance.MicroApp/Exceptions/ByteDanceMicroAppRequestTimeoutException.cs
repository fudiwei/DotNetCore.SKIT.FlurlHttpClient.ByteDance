using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Exceptions
{
    public class ByteDanceMicroAppRequestTimeoutException : ByteDanceMicroAppException
    {
        /// <inheritdoc/>
        internal ByteDanceMicroAppRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal ByteDanceMicroAppRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal ByteDanceMicroAppRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
