using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Exceptions
{
    public class TikTokShopEventSerializationException : TikTokShopException
    {
        /// <inheritdoc/>
        internal TikTokShopEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal TikTokShopEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokShopEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
