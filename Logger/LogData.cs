using System;
using nsILogLevel;

namespace nsLogData
{
    public class LogData
    {
        public string GetLogData(ILogLevel logLevel)
        {
            return "[" + logLevel.Name + " " + GetCurrentDateTime() + "]: " + logLevel.GetMessage();
        }

        //For Testing

        virtual protected string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
