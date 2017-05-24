using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnDotNetCore.ViewModels.Articles
{
    public class ArticlesIndexViewModel
    {
        public ICollection<ArticleViewModel> Articles { get; set; } = new List<ArticleViewModel>();
    }
}
