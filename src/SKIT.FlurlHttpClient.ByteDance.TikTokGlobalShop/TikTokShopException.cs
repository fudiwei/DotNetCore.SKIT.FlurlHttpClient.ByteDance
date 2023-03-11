using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// TikTok Shop API 出错时引发的异常。
    /// </summary>
    public class TikTokShopException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public TikTokShopException()
        {
        }

        /// <inheritdoc/>
        public TikTokShopException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public TikTokShopException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
