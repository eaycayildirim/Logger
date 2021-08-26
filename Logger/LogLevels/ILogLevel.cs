using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    interface ILogLevel
    {
        string GetStatus();

        string GetMessage();
    }
}
