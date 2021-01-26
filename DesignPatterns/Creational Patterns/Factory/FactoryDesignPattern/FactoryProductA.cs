namespace FactoryDesignPattern {

    /// <summary>
    /// Represents a factory that creates products of type A.
    /// </summary>
    public class FactoryProductA : Factory {

        /// <summary>
        /// Creates an instance of product A
        /// </summary>
        /// <returns></returns>
        public override IProduct CreateProduct() {

            return new ProductA();
        }
    }
}
