using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace FactoryDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            Factory factoryA = new FactoryProductA();
            CreateProductFromFactory(factoryA);

            Factory factoryB = new FactoryProductB();
            CreateProductFromFactory(factoryB);
        }


        protected void CreateProductFromFactory(Factory factory) {

            IProduct product = factory.CreateProduct();

            Debug.WriteLine($"Created product {product.GetType().Name}.");
        }
    }
}
