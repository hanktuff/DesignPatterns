using System.Diagnostics;

namespace CommandDesignPattern {
    public class Receiver {
        public void DoWork() {
            Debug.WriteLine("The receiver is doing some work.");
        }
    }
}
