using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Exercise_3
{
    class Logger
    {
        private static Logger instance;
        private string filePath;

        public string FilePath
        {
            set { this.filePath = value; }
        }

        private Logger()
        {
            this.FilePath = Environment.CurrentDirectory + @"\Log.txt";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }        
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
            {                
                writer.Write(message);
            }
        }
    }
}
