using System.Diagnostics;

namespace StrategyDesignPattern {
    public class Strategy2 : IStrategy {

        public void DoSomething() {
            Debug.WriteLine($"In {nameof(Strategy2)}.{nameof(DoSomething)}()");
        }
    }
}
