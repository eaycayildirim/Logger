﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsILogLevel
{
    public class Error : ILogLevel
    {
        public Error()
        {
            this.Name = "Error";
        }

        public string GetMessage()
        {
            return "This is an error message";
        }

        public string Name { get; }
    }
}
