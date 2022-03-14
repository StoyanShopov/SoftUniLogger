namespace Logger.Appenders
{
    using System;

    using Layouts;
    using ReportLevels;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        int AppendedMessages { get; }

        void Append(
            DateTime dateTime,
            ReportLevel reportLevel, //why not Enum?
            string message);
    }
}
