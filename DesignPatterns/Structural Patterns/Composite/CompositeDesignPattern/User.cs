using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CompositeDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            var root = new Composite();

            root.Leaves.Add(new Leaf());
            root.Leaves.Add(new Leaf());

            var subroot = new Composite();
            root.Leaves.Add(subroot);

            subroot.Leaves.Add(new Leaf());

            root.Operation();
        }
    }
}
