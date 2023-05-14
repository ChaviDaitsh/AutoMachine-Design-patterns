namespace AutoMachine.Decorator
{
    public abstract class ProducrDecorator : Product
    {
        public Product Product { get; set; }
        public ProducrDecorator(Product product)
        {
            this.Product = product;
        }
    }
}
