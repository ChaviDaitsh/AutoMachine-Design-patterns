using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    public class IceCoffeeBuilder:DrinkBuilder
    {
        IceCoffee IceCoffee = new IceCoffee();
        public IceCoffeeBuilder(IceCoffee coffee)
        {
            this.IceCoffee = coffee;
        }
        public override void AddFlavorPowder()
        {
            IceCoffee.Description += "with tasterchoice";
        }

        public override void AddMilk()
        {
            IceCoffee.Description += "and Milk";
        }

        public override Product GetResult()
        {
            return IceCoffee;
        }

        public override void Mix()
        {
            //mixing the coffee
        }

        public override void PourWater()
        {
            IceCoffee.Description += ", ice cubes";
        }
    }
}
