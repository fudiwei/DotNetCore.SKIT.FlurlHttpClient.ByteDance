using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Exceptions
{
    public class DouyinShopRequestTimeoutException : DouyinShopException
    {
        /// <inheritdoc/>
        internal DouyinShopRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
