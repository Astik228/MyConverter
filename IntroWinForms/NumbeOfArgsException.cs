using System;
using System.Runtime.Serialization;

namespace IntroWinForms
{
    [Serializable]
    internal class NumbeOfArgsException : Exception
    {
        public NumbeOfArgsException()
        {
        }

        public NumbeOfArgsException(string message) : base(message)
        {
        }

        public NumbeOfArgsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumbeOfArgsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}