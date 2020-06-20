using System;

namespace ProyectoArkanoid.Controladores
{
    public class NoRemainingLifesExeption : Exception
    {
        public NoRemainingLifesExeption(string Message) : base(Message) { }
    }
}
