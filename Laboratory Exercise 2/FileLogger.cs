using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_2
{
    class FileLogger : ILogger
    {
        /* Task 4
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        } 
        */

        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
    }
}
