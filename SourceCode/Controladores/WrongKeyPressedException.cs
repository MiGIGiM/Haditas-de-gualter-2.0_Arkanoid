using System;

namespace ProyectoArkanoid.Controladores
{
    public class WrongKeyPressedException : Exception
    {
        public WrongKeyPressedException(string Message) : base(Message) { }
    }
}
