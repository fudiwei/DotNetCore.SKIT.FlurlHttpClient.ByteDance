using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Exceptions
{
    public class DouyinShopRequestMarshalException : DouyinShopException
    {
        /// <inheritdoc/>
        internal DouyinShopRequestMarshalException()
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestMarshalException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinShopRequestMarshalException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
