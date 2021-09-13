using System;
using nsLog;

namespace nsILogLevel
{
    public class Info : ILogLevel
    {
        public Info()
        {
            this.Name = "Info";
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
