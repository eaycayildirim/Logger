using nsILogLevel;

namespace nsLoggerMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogLevel logCritical = new Critical();
            logCritical.Write("Critical");
        }
    }
}
