using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CommandDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            Command command = new Command();
            Invoker invoker = new Invoker(command);
            Receiver receiver = new Receiver();

            invoker.DoSomething();
        }
    }
}
