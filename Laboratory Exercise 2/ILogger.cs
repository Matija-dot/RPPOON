using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    interface ILogger
    {
        /* Task 4 
        void Log(string message);
        */

        void Log(ILogable data);
    }
}
