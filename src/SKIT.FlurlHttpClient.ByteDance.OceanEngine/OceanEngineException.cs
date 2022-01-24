using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    /// <summary>
    /// 巨量引擎开放平台 API 出错时引发的异常。
    /// </summary>
    public class OceanEngineException : CommonExceptionBase
    {
        /// <inheritdoc/>
        public OceanEngineException()
        {
        }

        /// <inheritdoc/>
        public OceanEngineException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        public OceanEngineException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
