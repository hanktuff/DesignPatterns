using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace PrototypeDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            ConcretePrototype1 p1 = new ConcretePrototype1("One");
            ConcretePrototype1 clone1 = (ConcretePrototype1)p1.Clone();
            Debug.WriteLine($"Cloned ID of 1 is \"{clone1.ID}\"");

            ConcretePrototype2 p2 = new ConcretePrototype2("Two");
            ConcretePrototype2 clone2 = (ConcretePrototype2)p2.Clone();
            Debug.WriteLine($"Cloned ID of 2 is \"{clone2.ID}\"");
        }
    }
}
