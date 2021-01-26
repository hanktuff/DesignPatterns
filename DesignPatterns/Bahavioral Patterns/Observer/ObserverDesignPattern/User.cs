using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ObserverDesignPattern {

    [TestClass]
    public class User {

        [TestMethod]
        public void TestMethod1() {

            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "Observer 1"));
            subject.Attach(new ConcreteObserver(subject, "Observer 2"));
            subject.Attach(new ConcreteObserver(subject, "Observer 3"));

            subject.State = "State 1";
            subject.Notify();

            subject.State = "State 2";
            subject.Notify();
        }
    }
}
