using System.Diagnostics;

namespace FacadeDesignPattern {
    public class Facade {

        protected Subsystem1 Subsystem1;
        protected Subsystem2 Subsystem2;
        protected Subsystem3 Subsystem3;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2, Subsystem3 subsystem3) {

            this.Subsystem1 = subsystem1;
            this.Subsystem2 = subsystem2;
            this.Subsystem3 = subsystem3;
        }

        public void Operation() {

            Debug.WriteLine("The Facade is calling the functions of the subsystems");

            this.Subsystem1.Operation();
            this.Subsystem2.DoSomething();
            this.Subsystem3.Operation();
            this.Subsystem3.WorkOnIt();
        }
    }
}
