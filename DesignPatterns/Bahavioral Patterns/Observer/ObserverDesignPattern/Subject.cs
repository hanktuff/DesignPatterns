using System.Collections.Generic;

namespace ObserverDesignPattern {
    public abstract class Subject {

        public void Attach(Observer observer) {

            Observers.Add(observer);
        }

        public void Detach(Observer observer) {

            Observers.Remove(observer);
        }

        public void Notify() {

            foreach (var observer in Observers) {
                observer.Update();
            }
        }


        protected List<Observer> Observers = new List<Observer>();
    }
}
