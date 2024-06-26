﻿
namespace AutoMachine
{
    public class IceCoffeeBuilder:DrinkBuilder
    {
        IceCoffee IceCoffee ;
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

        public override IceCoffee GetResult()
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
