using System.Diagnostics;

namespace StrategyDesignPattern {
    public class Context {

        private IStrategy _strategy;

        public Context(IStrategy strategy) {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy) {
            _strategy = strategy;
        }

        public void DoWork() {

            Debug.WriteLine($"Doing work using strategy {_strategy.GetType().Name}.");

            _strategy.DoSomething();
        }
    }
}
