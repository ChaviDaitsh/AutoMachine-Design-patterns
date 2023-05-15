

namespace AutoMachine
{
    public class IcedChocolateMilkBuilder:DrinkBuilder
    {
        IceChocolateMilk icedchocolateMilk = new IceChocolateMilk();
        public IcedChocolateMilkBuilder(IceChocolateMilk icedchocolateMilk)
        {
            this.icedchocolateMilk = icedchocolateMilk;
        }
        public override void AddFlavorPowder()
        {
            icedchocolateMilk.Description += "with chokolit";
        }

        public override void AddMilk()
        {
            icedchocolateMilk.Description += "and Milk";
        }

        public override Product GetResult()
        {
            return icedchocolateMilk;
        }

        public override void Mix()
        {
            //mixing the coffee
        }

        public override void PourWater()
        {
            icedchocolateMilk.Description += ", Ice cubes";
        }
    }
}
