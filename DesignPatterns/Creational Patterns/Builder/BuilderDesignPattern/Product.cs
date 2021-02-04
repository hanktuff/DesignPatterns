using System.Collections.Generic;

namespace BuilderDesignPattern {
    public class Product {

        private List<object> _parts = new List<object>();

        public void Add(object obj) {
            _parts.Add(obj);
        }

        public List<object> Parts {
            get {
                return _parts;
            }
        }
    }
}
