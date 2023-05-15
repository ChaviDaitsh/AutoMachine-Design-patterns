using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.report
{
    public class TodaysPurchase
    {
        public List<Purchase> PurchaseList { get; set; } = new List<Purchase>();

        public void AddPurchase(Purchase purchase)
        {
            PurchaseList.Add(purchase);
        }
    }
}
