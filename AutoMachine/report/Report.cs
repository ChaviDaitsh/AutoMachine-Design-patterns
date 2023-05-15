using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.report
{
    public abstract class Report
    {
        public List<Purchase> PurchaseList { get; set; }

        public Report(TodaysPurchase purchases)
        {
            PurchaseList = purchases.PurchaseList;
        }
        public abstract void WriteReport();
    }
}
