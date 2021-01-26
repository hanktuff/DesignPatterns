using System.Diagnostics;

namespace FacadeDesignPattern {
    public class Subsystem3 {

        public void Operation() {
            Debug.WriteLine($"In {nameof(Subsystem3)}.{nameof(Operation)}()");
        }

        public void WorkOnIt() {
            Debug.WriteLine($"In {nameof(Subsystem3)}.{nameof(WorkOnIt)}()");
        }
    }
}
