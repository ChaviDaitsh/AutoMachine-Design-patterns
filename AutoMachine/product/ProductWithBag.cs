

namespace AutoMachine
{
    internal class ProductWithBag : ProducrDecorator
    {
        public ProductWithBag(Product product) : base(product)
        {

        }
        public string ToString()
        {
            return base.ToString()+"with bag";
        }
    }
}
