namespace FactoryDesignPattern {

    /// <summary>
    /// Represents a factory for products.
    /// </summary>
    public abstract class Factory {

        /// <summary>
        /// Creates an instance of a product.
        /// </summary>
        /// <returns></returns>
        public abstract IProduct CreateProduct();
    }
}
