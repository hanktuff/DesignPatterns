namespace BuilderDesignPattern {
    public class ProductBuilder : IProductBuilder {

        private Product _product;

        public ProductBuilder() {

            _product = new Product();
        }

        public ProductBuilder AddPart1() {

            _product.Add("Part 1");
            return this;
        }

        public ProductBuilder AddPart2(object obj) {

            _product.Add($"Part 2; {obj.ToString()}; {obj.GetType().Name}");
            return this;
        }

        public ProductBuilder AddPart3() {

            _product.Add("Part 3");
            return this;
        }

        public Product GetProduct() {
            return _product;
        }
    }
}
