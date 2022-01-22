using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Exceptions
{
    public class TikTokShopRequestSignatureException : TikTokShopException
    {
        /// <inheritdoc/>
        internal TikTokShopRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
