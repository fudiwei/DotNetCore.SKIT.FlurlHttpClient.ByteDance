using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Exceptions
{
    public class DouyinOpenEventSerializationException : DouyinOpenException
    {
        /// <inheritdoc/>
        internal DouyinOpenEventSerializationException()
        {
        }

        /// <inheritdoc/>
        internal DouyinOpenEventSerializationException(string message)
            : base(message)
        {
        }

        /// <inheritdoc/>
        internal DouyinOpenEventSerializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
