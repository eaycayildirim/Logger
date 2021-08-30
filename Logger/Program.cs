using nsLog;
using nsLogData;
using nsILogLevel;

namespace nsLoggerMain
{
    class Program
    {
        static void Main(string[] args)
        {
            LogData data = new LogData();
            Log log = new Log();

            log.Write(data.GetLogData(new Info()));
        }
    }
}
