using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StrategyDesignPattern {
    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            IStrategy strategy = null;
            Context context = null;

            strategy = new Strategy1();
            context = new Context(strategy);

            context.DoWork();

            strategy = new Strategy2();
            context.SetStrategy(strategy);

            context.DoWork();
        }
    }
}
