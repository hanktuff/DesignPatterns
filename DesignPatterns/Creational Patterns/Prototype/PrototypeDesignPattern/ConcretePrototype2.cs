namespace PrototypeDesignPattern {
    public class ConcretePrototype2 : Prototype {

        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone() {

            return (Prototype)this.MemberwiseClone();
        }
    }
}
