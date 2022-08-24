using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Exceptions
{
    public class OceanEngineRequestTimeoutException : OceanEngineException
    {
        /// <inheritdoc/>
        internal OceanEngineRequestTimeoutException()
        {
        }

        /// <inheritdoc/>
        internal OceanEngineRequestTimeoutException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal OceanEngineRequestTimeoutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
