using System;

namespace DL
{
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }
    }
}