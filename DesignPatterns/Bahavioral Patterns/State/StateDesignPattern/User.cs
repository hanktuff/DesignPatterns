using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StateDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            var context = new Context(new ConcreteStateA());

            context.Request1();
            context.Request2();
        }
    }
}
