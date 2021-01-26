using System.Diagnostics;

namespace FacadeDesignPattern {
    public class Subsystem2 {

        public void DoSomething() {
            Debug.WriteLine($"In {nameof(Subsystem2)}.{nameof(DoSomething)}()");
        }
    }
}
