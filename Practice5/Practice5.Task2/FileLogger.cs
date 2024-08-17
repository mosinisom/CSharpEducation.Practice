using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice5.Task2
{
    internal class FileLogger : ILogger
    {
        string path = "log.txt";

        public void Trace(string message)
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Trace | {message}");
            }  
        }

        public void Info(string message)
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Info | {message}");
            }
        }

        public void Debug(string message)
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Debug | {message}");
            }
        }

        public void Error(string message) 
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Error | {message}");
            }
        }

        public void Fatal(string message) 
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Fatal | {message}");
            }
        }

        public void Warning(string message) 
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Warning | {message}");
            }
        }

        public void Log(string message, LogLevel level)
        {
            if (!File.Exists(this.path))
            {
                File.Create(this.path);
            }

            using (StreamWriter sw = File.AppendText(this.path))
            {
                sw.WriteLine($"{DateTime.Now} | {this.GetType().Name} | {level} | {message}");
            }
        }
       


    }
}
