using System;

namespace Section13
{
    class CustomException : Exception
    {
        public CustomException(string message)
            :base(message)
        {

        }
    }
}
