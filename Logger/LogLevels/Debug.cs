using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    public class Debug : ILogLevel
    {
        public Debug()
        {
            this.Name = "Debug";
            this.Message = "This is an debug message";
        }

        public string Name { get; }
        public string Message { get; }
    }
}
