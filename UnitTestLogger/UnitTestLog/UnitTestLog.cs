using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using nsLogTest;

namespace UnitTestLogger
{
    [TestClass]
    public class UnitTestLog
    {
        public UnitTestLog()
        {
            this._database = new LogTest(_filePath);
        }

        [TestMethod]
        public void WriteLine_WriteOneLine()
        {
            //Given
            _database.RemoveFile();
            var data = "Line";
            var expected = ("[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + data);

            //When
            _database.WriteLine(data);
            var actual = File.ReadAllText(_filePath);

            //Then
            Assert.IsTrue(File.Exists(_filePath));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WriteLog_WriteList()
        {
            //Given
            _database.RemoveFile();
            List<string> input = new List<string> { "Line1", "Line2"};
            var expected = "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + input[0] + "\n" +
                "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "]: " + input[1] + "\n";

            //When
            _database.WriteLog(input);
            var actual = File.ReadAllText(_filePath);

            //Then
            Assert.IsTrue(File.Exists(_filePath));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFilePath()
        {
            //Given
            var expected = DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";

            //When
            var actual = _database.GetFilePath();

            //Then
            Assert.AreEqual(expected, actual);
        }

        private LogTest _database;
        private string _filePath = "Test.txt";
    }
}
