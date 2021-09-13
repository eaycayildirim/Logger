using System;
using System.IO;

namespace nsLog
{
    public class Log
    {
        public Log()
        {
            Directory.CreateDirectory("Log/");
            this._filePath = "Log/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
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
