

namespace AutoMachine
{
    public class ReportFactory
    {

        public Report MakeReport(ReportFormat reportFormat, TodaysPurchase todaysPurchase) 
        {
            switch (reportFormat)
            {
                case ReportFormat.TextFormat:
                    return new TextReport(todaysPurchase);
            }
            return null;
        }
    }
}
