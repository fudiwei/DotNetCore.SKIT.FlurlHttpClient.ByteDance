using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 当调用抖音小程序 API 出错时引发的异常。
    /// </summary>
    public class DouyinMicroAppException : CommonException
    {
        /// <inheritdoc/>
        public DouyinMicroAppException()
        {
        }

        /// <inheritdoc/>
        public DouyinMicroAppException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public DouyinMicroAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
