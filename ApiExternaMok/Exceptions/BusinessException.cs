using System.Runtime.Serialization;

namespace ApiExternaMok.Exceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }

        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }    
}
