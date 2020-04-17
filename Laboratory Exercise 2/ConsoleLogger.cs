using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
            /* Task 4
            Console.WriteLine(message);
            */

            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
