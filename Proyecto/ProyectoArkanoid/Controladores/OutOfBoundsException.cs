using System;

namespace ProyectoArkanoid.Controladores
{
    public class OutOfBoundsException : Exception
    {
        public OutOfBoundsException(string Message) : base(Message) { }
    }
}
