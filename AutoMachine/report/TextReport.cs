﻿

namespace AutoMachine
{
    public class TextReport:Report
    {
        string reportName = "Report";
        string reportDay = DateTime.Now.DayOfWeek.ToString();

        public TextReport(TodaysPurchase purchases) : base(purchases)
        {
        }

        public override void WriteReport()
        {
            using (TextWriter textWriter = new StreamWriter($"\\.\\.\\reports\\{reportName + reportDay }.txt"))
            {
                foreach (Purchase s in PurchaseList)
                    textWriter.WriteLine(s.ToString());
            }
        }
    }
}
