using ChatLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Sockets;
using System.Reflection;
//using Castle.Components.DictionaryAdapter.Xml;


namespace Assignment1SolutionTest
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void DoesNetworkBaseClassExist()
        {
            Client c = new Client();
            Server s = new Server();
            var baseWarning = "Both client and server should have parent for common code called NetworkingBase";
            Assert.IsTrue(c is NetworkingBase, baseWarning);
            Assert.IsTrue(s is NetworkingBase, baseWarning);
            var oopStructure = "Base class should be abstract.";
            Type parentType = c.GetType().BaseType;
            Assert.AreEqual(parentType, s.GetType().BaseType, oopStructure);
            Assert.IsTrue(parentType.IsAbstract, oopStructure);
        }

        [TestMethod]
        public void TestBaseClassConstantsAndMethods()
        {
            Client c = new Client();
            Type parentType = c.GetType().BaseType;
            Assert.AreEqual(5555, NetworkingBase.PORT,
                "Have Port number as Constant for both client and server.");
            var noParams = new Type[] { };
            // Check base methods.
            var methodInfo = parentType.GetRuntimeMethod("GetMessage", noParams);
            Assert.IsNotNull(methodInfo,
                "Need a base GetMessage method that reads all bytes from a connected socket");
            Assert.AreEqual(methodInfo.ReturnType.Name, "String",
                "must return string from connected socket.");
            var stringParam = new Type[] { "".GetType() };
            methodInfo = parentType.GetRuntimeMethod("SendMessage", stringParam);
            Assert.IsNotNull(methodInfo,
                "Need a base SendMessage method that sends bytes as string to a connected socket");
            Assert.AreEqual(methodInfo.ReturnType.Name, "Void",
                "SendMessage method should not return any value.");
        }

        [TestMethod]
        public void TestClientSpecificFunctions()
        {
            Assert.AreEqual("127.0.0.1", Client.IPADDRESS, "Have localhost as Constant on client.");

            Client c = new Client();
            Assert.IsNotNull(c.GetComponentType().GetMethod("StartTcpClient"),
                "Should have start TCPClient method.");
            try
            {
                c.StartTcpClient(); // Setup the TCPClient and NetworkStream instance.
                Assert.Fail("There should be no server to connect to.");
            }
            catch (SocketException ex)
            {
                Assert.AreEqual("No connection could be made because " +
                    "the target machine actively refused it 127.0.0.1:5555", ex.Message,
                    "Cannot start TCP client as server should not be running.");
            }
            try
            {
                c.Disconnect();
                Assert.Fail("There should be no server to disconnect from.");
            }
            catch (NullReferenceException ne)
            {
                Assert.AreEqual("Object reference not set to an instance of an object.", ne.Message,
                    "Can't close NetworkStream as it is null in unit tests.");
            }
        }

        [TestMethod]
        public void TestServerSpecificFunctions()
        {
            Server s = new Server();
            s.StartServer(); // Start the server briefly.
            try
            {
                s.Disconnect();
                Assert.Fail("There should be no server to disconnect from.");
            }
            catch (NullReferenceException ne)
            {
                Assert.AreEqual("Object reference not set to an instance of an object.", ne.Message,
                    "Can't close NetworkStream as it should be null in unit tests.");
            }
        }
    }

    

    
}
