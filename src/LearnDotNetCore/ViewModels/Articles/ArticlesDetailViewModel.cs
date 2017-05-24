using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.ViewModels.Articles
{
    public class ArticlesDetailViewModel
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public DateTime PublicationDate { get; set; }

        public string Content { get; set; }
    }
}
