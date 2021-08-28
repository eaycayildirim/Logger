using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nsLog;

namespace nsLogTest
{
    public class LogTest : Log
    {
        public LogTest(string filePath, string dateTime) : base(filePath)
        {
            this._filePath = filePath;
        }

        ~LogTest()
        {
            if (File.Exists(_filePath))
                RemoveFile();
        }

        public void RemoveFile()
        {
            File.Delete(_filePath);
        }

        override protected string GetCurrentDateTime()
        {
            return "dd/MM/yyyy HH:mm:ss";
        }

        private string _filePath;
    }
}
