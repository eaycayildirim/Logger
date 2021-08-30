using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
