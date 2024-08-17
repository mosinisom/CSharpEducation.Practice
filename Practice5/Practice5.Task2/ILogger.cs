namespace Practice5.Task2
{
    internal interface ILogger
    {
        void Trace(string message);
        void Info(string message);
        void Debug(string message);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
        void Log(string message, LogLevel level);
    }
}
