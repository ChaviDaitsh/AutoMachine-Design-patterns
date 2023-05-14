using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.report
{
    public class Purchase
    {
        public ProductType Product { get; set; }
        public DateTime dateTime { get; set; }
        public double Price { get; set; }
        public double MoneyReceived { get; set; }
        public double Change { get; set; }

    }
}
