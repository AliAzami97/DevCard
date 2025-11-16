using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "Avalin Article Site" , "Ajab Articlie", "blog-post-thumb-5.jpg"),
                new Article(2, "Dovomin Article Site" , "Ajab Articliehaaaa", "blog-post-thumb-6.jpg"),
            };
            return View("_articles" , articles);
        }
    }
}
