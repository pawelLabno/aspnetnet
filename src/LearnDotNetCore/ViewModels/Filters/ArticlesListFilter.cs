using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.ViewModels.Filters
{
    public class ArticlesListFilter
    {
        public string Name { get; set; }

        public int? Elements { get; set; }
        public int? Page { get; set; }
    }
}
