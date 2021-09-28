using System;
using nsILogLevel;
using nsLog;

namespace nsLogLevel
{
    public class LogLevel : ILogLevel
    {
        public void Write(string message)
        {
            Log log = new Log();
            var data = GetLogData() + message;
            log.Write(data);
        }

        private string GetLogData()
        {
            return "[" + Name + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: ";
        }

        public string Name { get; set; }
    }
}
