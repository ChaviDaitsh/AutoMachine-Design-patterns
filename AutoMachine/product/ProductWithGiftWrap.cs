

namespace AutoMachine
{
    public class ProductWithGiftWrap : ProducrDecorator
    {
        public ProductWithGiftWrap(Product product) : base(product)
        {
            product.Price += 2;
        }
        public override string ToString()
        {
            return Product.ToString() + " with gift wrap";
        }
    }
}
