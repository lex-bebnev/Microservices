using System;

namespace Inspe.Common.Types
{
    public class InspeException : Exception
    {
        public string Code { get; }

        public InspeException()
        {
        }

        public InspeException(string code)
        {
            Code = code;
        }

        public InspeException(string message, params object[] args) 
            : this(string.Empty, message, args)
        {
        }

        public InspeException(string code, string message, params object[] args) 
            : this(null, code, message, args)
        {
        }

        public InspeException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public InspeException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}