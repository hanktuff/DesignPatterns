using System;
using System.Diagnostics;

namespace MediatorDesignPattern {

    public class Component2 : Component {

        public void DoSomething() {

            Debug.WriteLine("Componet 2 does something.");
            Mediator.Notify(this, "Something");
        }

        public void DoSomethingElse() {

            Debug.WriteLine("Componet 2 does something else.");
            Mediator.Notify(this, "SomethingElse");
        }

        public void Print(string message) {
            Debug.WriteLine($"Component 2 received: {message}" + Environment.NewLine);
        }
    }
}
