using System.Diagnostics;

namespace StateDesignPattern {
    public class ConcreteStateA : State {
        public override void Handle1() {
            Debug.WriteLine("ConcreteStateA handles request1.");
            Debug.WriteLine("ConcreteStateA wants to change the state of the context.");
            this.Context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2() {
            Debug.WriteLine("ConcreteStateA handles request2.");
        }
    }
}
