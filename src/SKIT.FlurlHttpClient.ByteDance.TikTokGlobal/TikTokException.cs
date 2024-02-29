using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 当调用 TikTok API 出错时引发的异常。
    /// </summary>
    public class TikTokException : CommonException
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
