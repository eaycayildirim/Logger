using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Error : ILogLevel
    {
        public string GetStatus()
        {
            return "Error";
        }

        public string GetMessage()
        {
            return "This is an error message";
        }
    }
}
