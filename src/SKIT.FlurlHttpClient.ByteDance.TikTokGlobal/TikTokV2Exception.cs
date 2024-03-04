using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 当调用 TikTok v2 API 出错时引发的异常。
    /// </summary>
    public class TikTokV2Exception : CommonException
    {
        /// <inheritdoc/>
        public TikTokV2Exception()
        {
        }

        /// <inheritdoc/>
        public TikTokV2Exception(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public TikTokV2Exception(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
