using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using nsLogTest;

namespace UnitTestLogger
{
    [TestClass]
    public class UnitTestLog
    {
        public UnitTestLog()
        {
            this._log = new LogTest(_filePath);
        }

        [TestMethod]
        public void Write_WriteSomething()
        {
            //Given
            _log.RemoveFile();
            var expected = "Line";

            //When
            _log.Write(expected);
            var actual = File.ReadAllText(_filePath);

            //Then
            Assert.IsTrue(File.Exists(_filePath));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFilePath()
        {
            //Given
            var expected = _filePath;

            //When
            var actual = _log.GetFileName();

            //Then
            Assert.AreEqual(expected, actual);
        }

        private LogTest _log;
        private string _filePath = "Test.log";
    }
}
