using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    public abstract class Supplier
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public abstract void OrderAProduct(ProductType productType, int numToOrder);
      
    }
}
