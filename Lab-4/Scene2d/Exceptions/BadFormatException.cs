namespace Scene2d.Exceptions
{
    using System;

    public class BadFormatException : Exception
    {
        public BadFormatException(string message)
        {
            ExceptionMessage = message;
        }

        public string ExceptionMessage { get; }
    }
}
