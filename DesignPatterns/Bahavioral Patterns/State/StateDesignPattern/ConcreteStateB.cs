using System.Diagnostics;

namespace StateDesignPattern {
    public class ConcreteStateB : State {
        public override void Handle1() {
            Debug.WriteLine("ConcreteStateB handles request1.");
        }

        public override void Handle2() {
            Debug.WriteLine("ConcreteStateB handles request2.");
            Debug.WriteLine("ConcreteStateB wants to change the state of the context.");
            this.Context.TransitionTo(new ConcreteStateA());
        }
    }
}
