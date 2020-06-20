using System;

namespace ProyectoArkanoid.Controladores
{
    public class ExceededMaxCharacterException : Exception
    {
        public ExceededMaxCharacterException(string Message) : base(Message) { }
    }
}
