﻿

namespace AutoMachine
{
    public class CoffeeBuilder : DrinkBuilder
    {
        Coffee coffee;
        public CoffeeBuilder(Coffee coffee)
        {
            this.coffee = coffee;
        }
        public override void AddFlavorPowder()
        {
            coffee.Description += "with tasterchoice";
        }

        public override void AddMilk()
        {
            coffee.Description += "and and skimmed Milk";
        }

        public override Coffee GetResult()
        {
            return coffee;
        }

        public override void Mix()
        {
            //mixing the coffee
        }

        public override void PourWater()
        {
            coffee.Description += ", hot water";
        }
        
    }
}
