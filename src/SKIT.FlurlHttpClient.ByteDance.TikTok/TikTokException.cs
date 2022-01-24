using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    /// <summary>
    /// 抖音开放平台 API 出错时引发的异常。
    /// </summary>
    public class TikTokException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public TikTokException()
        {
        }

        /// <inheritdoc/>
        public TikTokException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public TikTokException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
