using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    public class ChocolateMilkBuilder:DrinkBuilder
    {
        ChocolateMilk chocolateMilk = new ChocolateMilk();
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

        public override Product GetResult()
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
