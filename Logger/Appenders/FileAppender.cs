namespace Logger.Appenders
{
    using System;
    using System.IO;

    using Layouts;
    using LogFiles;
    using ReportLevels;

    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;
        private readonly string path;

        public FileAppender(
            ILayout layout,
            ILogFile logFile,
            string path)
            : base(layout)
        {
            this.logFile = logFile;
            this.path = path;
        }

        public override void Append(
            DateTime dateTime,
            ReportLevel reportLevel,
            string message)
        {

            this.logFile.Write(outputMessage);



            File.AppendAllText(
                path, 
                outputMessage + Environment.NewLine);
        }

        public override string ToString()
            => base.ToString() + $", File size: {this.logFile.Size}";
    }
}
