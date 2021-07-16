namespace AbstractFactoryDesignPattern {
    public class Products2 : IProducts {
        public ProductTypeA GetProductTypeA() => new Product2TypeA();

        public ProductTypeB GetProductTypeB() => new Product2TypeB();
    }
}
