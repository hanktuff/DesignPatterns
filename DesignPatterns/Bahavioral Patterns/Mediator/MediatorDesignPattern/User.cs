using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatorDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            // create the components

            var component1 = new Component1();
            var component2 = new Component2();

            // create the mediator

            var mediator = new Mediator(component1, component2);

            // set the mediator for each component

            component1.SetMediator(mediator);
            component2.SetMediator(mediator);

            // perform some action to see if the mediator tells the other component

            component1.DoSomething();
            component1.DoSomethingElse();

            component2.DoSomething();
            component2.DoSomethingElse();
        }
    }
}
