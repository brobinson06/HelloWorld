using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using HelloWorld.Interfaces;
using HelloWorld.Tests.TestAttributes;
using Moq;
using NLog;

namespace HelloWorld.Tests
{
    [TestClass, ExcludeFromCodeCoverage]
    public class DbRobotTests
    {
        [TestMethod, UnitTest]
        public void MrRobotoTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockCommunicator = new Mock<ICommunicatorFactory>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(mockLogger.Object, mockCommunicator.Object, mockConnection.Object);
            Assert.IsNotNull(robot);
        }

        [TestMethod, UnitTest, ExpectedException(typeof(ArgumentNullException))]
        public void MrRobotoNoLoggerTest()
        {
            var mockCommunicator = new Mock<ICommunicatorFactory>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(null, mockCommunicator.Object, mockConnection.Object);
        }
        [TestMethod, UnitTest, ExpectedException(typeof(ArgumentNullException))]
        public void MrRobotoNoCommunicatorTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(mockLogger.Object, null, mockConnection.Object);
        }

        [TestMethod, UnitTest, ExpectedException(typeof(ArgumentNullException))]
        public void MrRobotoNoConnnectionFactoryTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockCommunicator = new Mock<ICommunicatorFactory>();

            var robot = new DbRobot(mockLogger.Object, mockCommunicator.Object, null);
        }

        [TestMethod, UnitTest]
        public void GreetingTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockCommunicator = new Mock<ICommunicatorFactory>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(mockLogger.Object, mockCommunicator.Object, mockConnection.Object);
            // robot.Greeting();

            //todo: google how to unit test/assert on a console call function...someday...
        }

        [TestMethod, UnitTest, ExpectedException(typeof(NotImplementedException))]
        public void WriteToDatabaseTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockCommunicator = new Mock<ICommunicatorFactory>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(mockLogger.Object, mockCommunicator.Object, mockConnection.Object);
            robot.WriteToDatabase();
        }

        [TestMethod, UnitTest, ExpectedException(typeof(NotImplementedException))]
        public void WriteToConsoleApplicationTest()
        {
            var mockLogger = new Mock<ILogger>();
            var mockCommunicator = new Mock<ICommunicatorFactory>();
            var mockConnection = new Mock<IConnectionFactory>();

            var robot = new DbRobot(mockLogger.Object, mockCommunicator.Object, mockConnection.Object);
            robot.WriteToConsoleApplication();
        }
    }
}