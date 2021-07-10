﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    class Log
    {
        public Log()
        {
            this._filePath = "Logger.txt";
        }

        public Log(string filePath)
        {
            this._filePath = filePath;
        }

        public void WriteLog(List<string> list)
        {
            foreach (var item in list)
            {
                WriteLine(item+"\n");
            }
        }

        private void WriteLine(string data)
        {
            string log = ("[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + data);
            File.AppendAllText(_filePath, log);
        }

        private string _filePath;
    }
}
