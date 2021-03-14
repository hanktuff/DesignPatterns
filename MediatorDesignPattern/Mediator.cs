using System.Diagnostics;

namespace MediatorDesignPattern {
    public class Mediator : IMediator {

        private Component1 _component1;
        private Component2 _component2;

        public Mediator(Component1 component1, Component2 component2) {

            _component1 = component1;
            _component1.SetMediator(this);

            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string message) {
            
            if (message == "Something") {

                Debug.WriteLine("Mediator reacts to Something.");

                if (sender is Component1) { _component2.Print("Notification from Mediator"); }
                if (sender is Component2) { _component1.Print("Notification from Mediator"); }
            }

            if (message == "SomethingElse") {

                Debug.WriteLine("Mediator reacts to SomethingElse.");

                if (sender is Component1) { _component2.Print("Notification from Mediator"); }
                if (sender is Component2) { _component1.Print("Notification from Mediator"); }
            }
        }
    }
}
