using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    public abstract class DrinkBuilder
    {
        //public Product Product { get; set; }

        public abstract void PourWater();
        public abstract void AddFlavorPowder();
        public abstract void AddMilk();
        public abstract void Mix();
        public abstract Product GetResult();
    }
}
