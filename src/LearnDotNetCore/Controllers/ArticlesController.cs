using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LearnDotNetCore.Models;
using LearnDotNetCore.ViewModels.Articles;
using LearnDotNetCore.ViewModels.Filters;
using Microsoft.AspNetCore.Mvc;
using LearnDotNet.Domain;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnDotNetCore.Controllers
{
    [Route("articles")]
    public class ArticlesController : Controller
    {
        private readonly BlogDbContext ctx;
        private readonly IReportProvider reportProvider;

        public ArticlesController(BlogDbContext ctx, IReportProvider reportProvider)
        {
            this.ctx = ctx;
            this.reportProvider = reportProvider;
        }


        [Route("")]
        // GET: /<controller>/
        public Task<IActionResult> IndexAsync( [FromQuery] ArticlesListFilter filter, CancellationToken ct)
        {
            var parameters = filter ?? new ArticlesListFilter();
            var articlesVm = new ArticlesIndexViewModel();

            var articles = ctx.Articles.ToList();

            foreach (var article in articles)
            {
                articlesVm.Articles.Add(new ArticleViewModel
                {
                    PublicationDate = article.PublicationDate,
                    Name = article.Name
                });
            }

            return Task.FromResult<IActionResult>(View("Index",articlesVm));
        }

        [Route("{articleId:int}")]
        public Task<IActionResult> DetailsAsync(int articleId, CancellationToken ct)
        {
            var articlesDetailsVm = new ArticlesDetailViewModel();

            var article = ctx.Articles.First(a => a.Id ==  articleId);

            articlesDetailsVm.PublicationDate = article.PublicationDate;
            articlesDetailsVm.Content = article.Content;
            articlesDetailsVm.Name = article.Name;

            return Task.FromResult<IActionResult>(View("Details", articlesDetailsVm));
        }

        [Route("reports")]
        public IActionResult Reports()
        {
            var reports = reportProvider.GetAllReports();
            return new ObjectResult(reports);
        }
    }
}
