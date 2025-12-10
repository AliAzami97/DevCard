using DevCard_Project.Data;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = ProjectDetail.GetProjects();

            return View("_projects", projects);
        }
    }
}
