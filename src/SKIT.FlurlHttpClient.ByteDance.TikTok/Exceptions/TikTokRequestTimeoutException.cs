using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Exceptions
{
    public class TikTokRequestTimeoutException : TikTokException
    {
        /// <inheritdoc/>
        internal TikTokRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal TikTokRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
