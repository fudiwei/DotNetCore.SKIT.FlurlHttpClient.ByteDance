using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 字节小程序 API 出错时引发的异常。
    /// </summary>
    public class ByteDanceMicroAppException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public ByteDanceMicroAppException()
        {
        }

        /// <inheritdoc/>
        public ByteDanceMicroAppException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public ByteDanceMicroAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
