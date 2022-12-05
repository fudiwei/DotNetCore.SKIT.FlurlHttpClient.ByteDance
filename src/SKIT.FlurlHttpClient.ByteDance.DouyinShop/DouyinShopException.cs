using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    /// <summary>
    /// 抖店开放平台 API 出错时引发的异常。
    /// </summary>
    public class DouyinShopException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public DouyinShopException()
        {
        }

        /// <inheritdoc/>
        public DouyinShopException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public DouyinShopException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
