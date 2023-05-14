using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    public class ChocolateMilk : Product
    {
        public string Description { get; set; }
        public string ToString()
        {
            return base.ToString() + Description;
        }
    }
}
