using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Exceptions
{
    public class TikTokShopRequestTimeoutException : TikTokShopException
    {
        /// <inheritdoc/>
        internal TikTokShopRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
