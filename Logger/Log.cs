using System;
using System.Collections.Generic;
using System.IO;

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

        public void Write(List<string> list)
        {
            foreach (var item in list)
            {
                Write(item + "\n");
            }
        }

        public void Write(string data)
        {
            string log = ("[" + GetCurrentDateTime() + "]: " + data);
            File.AppendAllText(_filePath, log);
        }

        public string GetFileName()
        {
            return _filePath;
        }

        //For Testing

        virtual protected string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private string _filePath;
    }
}
