using System;

namespace ProyectoArkanoid.Controladores
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string Message) : base(Message) { }
    }
}
