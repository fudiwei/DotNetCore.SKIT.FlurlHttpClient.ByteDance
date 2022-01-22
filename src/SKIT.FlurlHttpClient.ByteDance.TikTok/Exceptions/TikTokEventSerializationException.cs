using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Exceptions
{
    public class TikTokEventSerializationException : TikTokException
    {
        /// <inheritdoc/>
        internal TikTokEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal TikTokEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
