using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.report
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
