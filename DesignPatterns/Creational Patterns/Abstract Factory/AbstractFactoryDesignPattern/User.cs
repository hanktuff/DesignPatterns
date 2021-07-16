using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AbstractFactoryDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            List<IProducts> factories = new List<IProducts>();

            factories.Add(new Products1());
            factories.Add(new Products2());
            factories.Add(new Products3());

            foreach (var factory in factories) {

                Debug.WriteLine($"Factory of type {factory.GetType().Name} produced Type A class: \"{factory.GetProductTypeA().GetInfo()}\".");
                Debug.WriteLine($"Factory of type {factory.GetType().Name} produced Type B class: \"{factory.GetProductTypeB().GetInfo()}\".");
            }
        }
    }
}
