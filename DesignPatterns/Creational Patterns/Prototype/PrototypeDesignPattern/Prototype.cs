namespace PrototypeDesignPattern {
    public abstract class Prototype {

        public Prototype(string id) {

            this.ID = id;
        }

        public string ID { get; private set; }

        public abstract Prototype Clone();
    }
}
