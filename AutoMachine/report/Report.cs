

namespace AutoMachine
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
