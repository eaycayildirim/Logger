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
            var data = "[" + Name + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + message;
            log.Write(data);
        }

        public string Name { get; set; }
    }
}
