using System;

namespace Milestone1.Exceptions
{
    public class PlatoInvalidoException : Exception
    {
        public PlatoInvalidoException(string mensaje) : base(mensaje) { }
    }
}
