using System;

namespace SQLib
{
    public class SQLHandlerException : Exception
    {
        public new string Message;
        public SQLHandlerException(string message) : base(message)
        {
            Message = message;
        }
    }
}