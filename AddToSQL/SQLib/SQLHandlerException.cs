using System;

namespace SQLib
{
    public class SQLHandlerException : Exception
    {
        public string Message;
        public SQLHandlerException(string message) : base(message)
        {
            Message = message;
        }
    }

}