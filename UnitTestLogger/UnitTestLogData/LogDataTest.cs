using nsLogData;

namespace UnitTestLogger
{
    class LogDataTest : LogData
    {
        override protected string GetCurrentDateTime()
        {
            return "dd/MM/yyyy HH:mm:ss";
        }
    }
}
