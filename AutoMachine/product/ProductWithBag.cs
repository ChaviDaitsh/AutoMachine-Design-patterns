using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.Decorator
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
