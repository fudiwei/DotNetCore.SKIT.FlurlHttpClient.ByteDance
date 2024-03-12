using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 当调用抖音开放平台 API 出错时引发的异常。
    /// </summary>
    public class DouyinOpenException : CommonException
    {
        /// <inheritdoc/>
        public DouyinOpenException()
        {
        }

        /// <inheritdoc/>
        public DouyinOpenException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public DouyinOpenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
