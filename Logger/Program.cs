using nsLogLevel;

namespace nsLoggerMain
{
    class Program
    {
        static void Main(string[] args)
        {
            LogLevel logCritical = new Critical();
            logCritical.Write("Critical");
        }
    }
}
