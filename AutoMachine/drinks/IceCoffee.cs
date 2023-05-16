

namespace AutoMachine
{
    public class IceCoffee:Product
    {
        public string Description { get; set; }
        public IceCoffee(Product product) : base(product.Name, product.Price)
        {
        }
        public override string ToString()
        {
            return base.ToString() + Description;
        }
    }
}
