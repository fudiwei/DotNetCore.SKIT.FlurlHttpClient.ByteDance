using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Exceptions
{
    public class DouyinShopRequestSignatureException : DouyinShopException
    {
        /// <inheritdoc/>
        internal DouyinShopRequestSignatureException()
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestSignatureException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestSignatureException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
