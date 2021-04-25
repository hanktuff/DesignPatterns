using System.Diagnostics;

namespace StateDesignPattern {
    public class Context {

        protected State State = null;

        public Context(State state) {

            this.TransitionTo(state);
        }

        public void TransitionTo(State state) {

            Debug.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this.State = state;
            this.State.SetContext(this);
        }

        public void Request1() {

            this.State.Handle1();
        }

        public void Request2() {

            this.State.Handle2();
        }
    }
}
