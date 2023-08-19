using System.Runtime.Serialization;

namespace ApiExternaMok.Exceptions
{
    [Serializable]
    public class ValidationsException : Exception
    {
        public ValidationsException(string message) : base(message) { }

        protected ValidationsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
