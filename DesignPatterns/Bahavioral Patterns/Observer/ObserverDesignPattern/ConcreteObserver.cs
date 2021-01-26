using System;
using System.Diagnostics;

namespace ObserverDesignPattern {
    public class ConcreteObserver : Observer {

        private string _name;
        private string _state;

        public ConcreteObserver(ConcreteSubject subject, string name) {

            Subject = subject;
            _name = name;
        }

        public override void Update() {

            _state = Subject.State;

            Debug.WriteLine($"Observer {_name}'s new state is {Subject.State}.");
        }

        public ConcreteSubject Subject { get; set; }
    }
}
