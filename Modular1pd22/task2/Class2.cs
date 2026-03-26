using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class FileLogger
    {
        private string _fileName = "logPD22.txt";

        public void LogToFile(string message)
        {
            string logEntry = $"[{DateTime.Now:HH:mm:ss}] {message}";

            File.AppendAllText(_fileName, logEntry + Environment.NewLine);
        }
    }
}
