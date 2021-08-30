using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var actual = logData.GetLogData(new Error());

            //Then
            Assert.AreEqual(expected, actual);
        }

        private LogDataTest logData;
    }
}
