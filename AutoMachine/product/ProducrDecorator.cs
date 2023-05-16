namespace AutoMachine
{
    public abstract class ProducrDecorator : Product
    {
        public Product Product { get; set; }
        public ProducrDecorator(Product product):base(product.Name, product.Price)
        {
            this.Product = product;
        }
    }
}
