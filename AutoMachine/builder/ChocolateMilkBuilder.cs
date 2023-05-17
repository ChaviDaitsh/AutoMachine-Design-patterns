

namespace AutoMachine
{
    public class ChocolateMilkBuilder:DrinkBuilder
    {

        ChocolateMilk chocolateMilk;
        public ChocolateMilkBuilder(ChocolateMilk chocolateMilk)
        {
            this.chocolateMilk = chocolateMilk;
        }
        public override void AddFlavorPowder()
        {
            chocolateMilk.Description += "with chokolit";
        }

        public override void AddMilk()
        {
            chocolateMilk.Description += "and skimmed Milk";
        }

        public override ChocolateMilk GetResult()
        {
            return chocolateMilk;
        }

        public override void Mix()
        {
            //mixing the coffee
        }

        public override void PourWater()
        {
            chocolateMilk.Description += ", hot water";
        }
    }
}
