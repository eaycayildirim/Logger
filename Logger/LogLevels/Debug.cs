using System;
using nsLog;

namespace nsILogLevel
{
    public class Debug : ILogLevel
    {
        public Debug()
        {
            this.Name = "Debug";
        }

        public void Write(string message)
        {
            Log log = new Log();
            var data = "[" + Name + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + message;
            log.Write(data);
        }

        public string Name { get; }
    }
}
