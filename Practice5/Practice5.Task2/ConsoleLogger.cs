using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2
{
    internal class ConsoleLogger : ILogger
    {
        public void Trace(string message)
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Trace | {message}");
        }

        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Info | {message}");
        }

        public void Debug(string message)
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Debug | {message}");
        }

        public void Error(string message) 
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Error | {message}");
        }

        public void Fatal(string message) 
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Fatal | {message}");
        }

        public void Warning(string message) 
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | Warning | {message}");
        }

        public void Log(string message, LogLevel level)
        {
            Console.WriteLine($"{DateTime.Now} | {this.GetType().Name} | {level} | {message}");
        }
    }
}
