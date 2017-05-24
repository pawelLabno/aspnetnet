using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnDotNet.Domain;

namespace Learn.Infrastructure
{
    public class ReportProvider : IReportProvider
    {


        public ICollection<Report> GetAllReports()
        {
            return new List<Report>
            {
                new Report
                {
                    TestPole =  123
                }
            };
        }
    }
}
