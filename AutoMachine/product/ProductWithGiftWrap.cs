using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.Decorator
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
