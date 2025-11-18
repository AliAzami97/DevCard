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
                    Id = 1, Name = "ApiRepository", Description="سامانه ای جهت سهولت دسترسی به دیتابیس به همراه تمامی جزئیات آن اعم از Spها، Schemaها، Tableها، و... .و نه تنها دسترسی بلکه تمامی اعمالی که امکان اجرای آن روی دیتابیس وجود دارد را شامل می شود و دقیقاً مثل یک محیط مبتنی بر دیتابیس عمل می کند که حاصل دسترنج تیم DarkMode زیرنظر آقای محمدی هستند، می باشد. " , Image = "Screenshot 2025-11-17 164341.jpg", Client = "EveryBody"
                },
                 new Project()
                {
                    Id = 2, Name = " Siban", Description="این پروژه، جهت انتقال تمامی اطلاعات، عملیات ها، جداول، و... مربوط به سامانه همراه که سابقاً  (در حال حاضر) در تمامی شعب بانک رفاه کارگران در دسترس بوده اما به جهت نوآوری و مدرن سازی آن به سامانه سیبان تغییر پیدا کرده است. بنده نیز جزء کوچکی از این پیشبرد را به عهده دارد. " , Image = "Screenshot 2025-11-17 164455.jpg", Client = "EveryBody"
                }
            };
            return View("_projects", project);
        }
    }
}
