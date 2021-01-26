using System.Diagnostics;

namespace CommandDesignPattern {
    public class Invoker {

        private ICommand _command = null;

        public Invoker(ICommand command) {
            _command = command;
        }

        public void DoSomething() {

            Debug.WriteLine("The invoker does something.");

            if (_command != null) {
                _command.ExecuteCommand();
            }

            Debug.WriteLine("The invoker does something else.");
        }
    }
}
