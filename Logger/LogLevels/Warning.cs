using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Warning : ILogLevel
    {
        public string GetStatus()
        {
            return "Warning";
        }
        public string GetMessage()
        {
            return "This is a warning message";
        }
    }
}
