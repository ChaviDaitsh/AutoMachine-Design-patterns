

namespace AutoMachine
{
    public class TextReport:Report
    {
        string reportDay = DateTime.Now.DayOfWeek.ToString();

        public TextReport(TodaysPurchase purchases) : base(purchases)
        {

        }

       

        public override void WriteReport()
        {
            try
            {
                string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
                TextWriter sr = new StreamWriter($"H:\\reports\\{dayOfWeek}.txt");
                WriteReportTitle(sr);
                WriteReportContent(sr);
                WriteReportSummary(sr);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public override void WriteAditionalCalculations(TextWriter sr)
        {
            throw new NotImplementedException();
        }
        public override void WriteReportContent(TextWriter sr)
        {
            sr.WriteLine("content:");
                foreach (Purchase s in PurchaseList)
                    sr.WriteLine(s.ToString());
            
        }
        public override void WriteReportSummary(TextWriter sr)
        {
            sr.WriteLine("This is today's report");
        }

        public override void WriteReportTitle(TextWriter sr)
        {
            sr.WriteLine($"Daily text report, {reportDay}");
        }
    }
}
