using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNet.Domain
{
    public interface IReportProvider
    {
        ICollection<Report> GetAllReports();
    }
}
