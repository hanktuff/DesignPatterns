using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FacadeDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();
            var subsystem3 = new Subsystem3();

            Facade facade = new Facade(subsystem1, subsystem2, subsystem3);

            facade.Operation();
        }
    }
}
