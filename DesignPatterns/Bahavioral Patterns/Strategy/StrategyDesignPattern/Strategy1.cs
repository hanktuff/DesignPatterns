using System.Diagnostics;

namespace StrategyDesignPattern {
    public class Strategy1 : IStrategy {

        public void DoSomething() {
            Debug.WriteLine($"In {nameof(Strategy1)}.{nameof(DoSomething)}()");
        }
    }
}
