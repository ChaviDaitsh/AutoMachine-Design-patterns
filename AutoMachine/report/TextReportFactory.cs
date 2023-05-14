using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.report
{
    internal class TextReportFactory : ReportFactory
    {
        public override Report MakeReport()
        {
            return new TextReport();
            
        }
    }
}
