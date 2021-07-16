namespace AbstractFactoryDesignPattern {
    public class Products1 : IProducts {
        public ProductTypeA GetProductTypeA() => new Product1TypeA();

        public ProductTypeB GetProductTypeB() => new Product1TypeB();
    }
}
