namespace AbstractFactoryDesignPattern {
    public class Products3 : IProducts {
        public ProductTypeA GetProductTypeA() => new Product3TypeA();

        public ProductTypeB GetProductTypeB() => new Product3TypeB();
    }
}
