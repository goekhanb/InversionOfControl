using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public class Logger : ILogger
    {

        public void Log(string message)
        {
            Console.WriteLine($"write to Console: {message}");
        }
    }
}
