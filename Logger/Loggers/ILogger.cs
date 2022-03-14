namespace Logger.Loggers
{
    using Appenders;

    public interface ILogger
    {
        IAppender[] Appenders { get; }

        void Info(string message);

        void Warning(string message);

        void Error(string message);

        void Crticical(string message);

        void Fatal(string message);
    }
}
