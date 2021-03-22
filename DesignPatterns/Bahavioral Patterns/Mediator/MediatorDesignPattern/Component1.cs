using System;
using System.Diagnostics;

namespace MediatorDesignPattern {

    public class Component1 : Component {

        public void DoSomething() {

            Debug.WriteLine("Componet 1 does something.");
            Mediator.Notify(this, "Something");
        }

        public void DoSomethingElse() {

            Debug.WriteLine("Componet 1 does something else.");
            Mediator.Notify(this, "SomethingElse");
        }

        public void Print(string message) {
            Debug.WriteLine($"Component 1 received: {message}" + Environment.NewLine);
        }
    }
}
