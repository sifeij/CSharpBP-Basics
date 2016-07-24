using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.Common.Tests
{
    [TestClass()]
    public class LoggingServiceTests
    {
        [TestMethod()]
        public void LogAction_Success()
        {
            // Arrange
            var expected = "Action: Test Action";

            // Act
            var actual = LoggingService.LogAction("Test Action");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}