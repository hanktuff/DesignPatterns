using System.Diagnostics;

namespace FacadeDesignPattern {
    public class Subsystem1 {

        public void Operation() {
            Debug.WriteLine($"In {nameof(Subsystem1)}.{nameof(Operation)}()");
        }
    }
}
