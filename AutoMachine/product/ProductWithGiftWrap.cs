

namespace AutoMachine
{
    public class ProductWithGiftWrap : ProducrDecorator
    {
        public ProductWithGiftWrap(Product product) : base(product)
        {
            product.Price += 2;
        }
        public string ToString()
        {
            return base.ToString() + "with gift wrap";
        }
    }
}
