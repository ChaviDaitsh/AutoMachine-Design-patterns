

namespace AutoMachine
{
    internal class ProductWithBag : ProducrDecorator
    {
        public ProductWithBag(Product product) : base(product)
        {

        }
        public override string ToString()
        {
            return Product.ToString()+" with bag";
        }
    }
}
