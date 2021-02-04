using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace BuilderDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            Product product = null;
            IProductBuilder productBuilder = new ProductBuilder();

            productBuilder.AddPart1();
            productBuilder.AddPart2("Hi!");
            productBuilder.AddPart2(new ObjectDisposedException("another part 2"));
            productBuilder.AddPart3();

            product = productBuilder.GetProduct();

            foreach (var part in product.Parts) {

                Debug.WriteLine(part?.ToString());
            }
        }
    }
}
