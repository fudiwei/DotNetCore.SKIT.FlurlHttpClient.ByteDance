using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Exceptions
{
    public class DouyinOpenRequestTimeoutException : DouyinOpenException
    {
        /// <inheritdoc/>
        internal DouyinOpenRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal DouyinOpenRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinOpenRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
