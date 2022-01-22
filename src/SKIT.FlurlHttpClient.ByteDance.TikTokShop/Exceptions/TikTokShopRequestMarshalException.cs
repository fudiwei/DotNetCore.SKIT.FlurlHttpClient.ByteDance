using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Exceptions
{
    public class TikTokShopRequestMarshalException : TikTokShopException
    {
        /// <inheritdoc/>
        internal TikTokShopRequestMarshalException()
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestMarshalException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal TikTokShopRequestMarshalException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
