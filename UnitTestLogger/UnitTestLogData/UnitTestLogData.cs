using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using nsILogLevel;

namespace UnitTestLogger
{
    [TestClass]
    public class UnitTestLogData
    {
        public UnitTestLogData()
        {
            this.logData = new LogDataTest();
        }

        [TestMethod]
        public void GetLog()
        {
            //Given
            var expected = "[Error dd/MM/yyyy HH:mm:ss]: This is an error message";

            //When
            var actual = logData.GetLog(new Error());

            //Then
            Assert.AreEqual(expected, actual);
        }

        private LogDataTest logData;
    }
}
