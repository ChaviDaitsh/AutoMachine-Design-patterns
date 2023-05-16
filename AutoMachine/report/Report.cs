

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
        public abstract void WriteReportTitle(TextWriter sr);
        public abstract void WriteReportContent(TextWriter sr);
        public abstract void WriteAditionalCalculations(TextWriter sr);
        public abstract void WriteReportSummary(TextWriter sr);
    }
}
