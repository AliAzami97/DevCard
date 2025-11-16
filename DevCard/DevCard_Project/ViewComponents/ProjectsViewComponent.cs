using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var project = new List<Project>()
            {
                new Project()
                {
                    Id = 1, Name = "Avali", Description="Prozhe Tamiz" , Image = "profile.png", Client = "Khodam"
                },
                 new Project()
                {
                    Id = 2, Name = "Dovomi", Description="Prozhe Tamiz2" , Image = "profile-lg.jpg", Client = "Khodet"
                }
            };
            return View("_projects", project);
        }
    }
}
