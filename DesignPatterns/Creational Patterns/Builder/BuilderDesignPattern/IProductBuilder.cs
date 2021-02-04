namespace BuilderDesignPattern {
    public interface IProductBuilder {

        ProductBuilder AddPart1();
        ProductBuilder AddPart2(object obj);
        ProductBuilder AddPart3();
        Product GetProduct();
    }
}
