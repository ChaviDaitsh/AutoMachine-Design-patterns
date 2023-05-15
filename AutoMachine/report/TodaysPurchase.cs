

namespace AutoMachine
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
