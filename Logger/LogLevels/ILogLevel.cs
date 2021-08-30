using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    public interface ILogLevel
    {
        string Name { get; }

        string GetMessage();
    }
}
