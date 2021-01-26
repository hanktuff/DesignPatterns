using System.Diagnostics;

namespace StrategyDesignPattern {
    public class Strategy3 : IStrategy {

        public void DoSomething() {
            Debug.WriteLine($"In {nameof(Strategy3)}.{nameof(DoSomething)}()");
        }
    }
}
