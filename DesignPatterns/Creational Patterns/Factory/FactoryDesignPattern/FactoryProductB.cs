namespace FactoryDesignPattern {

    /// <summary>
    /// Represents a factory that creates products of type B.
    /// </summary>
    public class FactoryProductB : Factory {

        /// <summary>
        /// Creates an instance of product B.
        /// </summary>
        /// <returns></returns>
        public override IProduct CreateProduct() {

            return new ProductB();
        }
    }
}
