using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    class Info : ILogLevel
    {
        public string GetStatus()
        {
            return "Info";
        }
        public string GetMessage()
        {
            return "This is an info message";
        }
    }
}
