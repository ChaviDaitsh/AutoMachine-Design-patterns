

namespace AutoMachine
{
    public class DrinkMaker
    {
        public void MakeDrink(DrinkBuilder builder)
        {
            builder.AddFlavorPowder();
            builder.PourWater();
            builder.Mix();
            builder.AddMilk();
            builder.Mix();
        }
       
    }
}
