using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    public class Critical : ILogLevel
    {
        public Critical()
        {
            this.Name = "Critical";
        }

        public string GetMessage()
        {
            return "This is a critical message";
        }

        public string Name { get; }
    }
}
