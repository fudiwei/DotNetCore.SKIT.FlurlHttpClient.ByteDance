using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Exceptions
{
    public class DouyinShopEventSerializationException : DouyinShopException
    {
        /// <inheritdoc/>
        internal DouyinShopEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal DouyinShopEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinShopEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
