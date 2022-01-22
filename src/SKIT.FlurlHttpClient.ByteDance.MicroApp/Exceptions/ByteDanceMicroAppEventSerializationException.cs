using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Exceptions
{
    public class ByteDanceMicroAppEventSerializationException : ByteDanceMicroAppException
    {
        /// <inheritdoc/>
        internal ByteDanceMicroAppEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal ByteDanceMicroAppEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal ByteDanceMicroAppEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
