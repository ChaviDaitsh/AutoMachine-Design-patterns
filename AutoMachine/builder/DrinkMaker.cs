using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.builder
{
    public class DrinkMaker
    {
        public void MakeCoffee(CoffeeBuilder builder)
        {
            builder.AddFlavorPowder();
            builder.PourWater();
            builder.Mix();
            builder.AddMilk();
            builder.Mix();
        }
        public void MakeIceCoffee(IceCoffeeBuilder builder)
        {
            builder.AddFlavorPowder();
            builder.PourWater();
            builder.Mix();
            builder.AddMilk();
            builder.Mix();
        }
        public void MakeChocolateMilk(ChocolateMilkBuilder builder)
        {
            builder.AddFlavorPowder();
            builder.PourWater();
            builder.Mix();
            builder.AddMilk();
            builder.Mix();
        }
        public void MakeIcedChocolateMilk(IcedChocolateMilkBuilder builder)
        {
            builder.AddFlavorPowder();
            builder.PourWater();
            builder.Mix();
            builder.AddMilk();
            builder.Mix();
        }
    }
}
