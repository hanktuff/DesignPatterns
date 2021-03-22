using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace SingletonDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2) {

                Debug.WriteLine("Both singletons are the same.");
            } else {

                Debug.WriteLine("The singletons are not the same.");
            }
        }
    }
}
