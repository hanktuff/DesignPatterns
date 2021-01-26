using System.Diagnostics;

namespace CompositeDesignPattern {
    public class Leaf : Component {

        public override void Operation() {

            Debug.WriteLine("Operation() in Leaf class.");
        }
    }
}
