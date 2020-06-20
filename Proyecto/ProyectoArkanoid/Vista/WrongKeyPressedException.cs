using System;
using System.Runtime.Serialization;

namespace ProyectoArkanoid.Vista
{
    [Serializable]
    internal class WrongKeyPressedException : Exception
    {
        public WrongKeyPressedException()
        {
        }

        public WrongKeyPressedException(string message) : base(message)
        {
        }

        public WrongKeyPressedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongKeyPressedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}