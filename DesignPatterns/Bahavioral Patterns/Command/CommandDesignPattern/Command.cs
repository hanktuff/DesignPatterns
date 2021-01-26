using System.Diagnostics;

namespace CommandDesignPattern {
    public class Command : ICommand {

        private Receiver _receiver = new Receiver();

        public void ExecuteCommand() {

            Debug.WriteLine("Executing the command...");
            _receiver.DoWork();
        }
    }
}
