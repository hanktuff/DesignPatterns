using System.Collections.Generic;
using System.Diagnostics;

namespace CompositeDesignPattern {
    public class Composite : Component {

        public List<Component> Leaves = new List<Component>();

        public override void Operation() {

            Debug.WriteLine("Operation() in Composite class.");

            foreach (var item in this.Leaves) {
                item.Operation();
            }
        }
    }
}
