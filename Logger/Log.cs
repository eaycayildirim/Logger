using System;
using System.Collections.Generic;
using System.IO;
using nsILogLevel;

namespace nsLog
{
    public class Log
    {
        public Log()
        {
            this._filePath = DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
        }

        public Log(string filePath)
        {
            this._filePath = filePath;
        }

        public void Write(string data)
        {
            File.AppendAllText(_filePath, data);
        }

        public string GetFileName()
        {
            return _filePath;
        }

        private string _filePath;
    }
}
