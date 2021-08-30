using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    public class Info : ILogLevel
    {
        public Info()
        {
            this.Name = "Info";
            this.Message = "This is an info message";
        }

        public string Name { get; }
        public string Message { get; }
    }
}
