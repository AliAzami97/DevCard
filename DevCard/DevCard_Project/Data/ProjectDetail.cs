using DevCard_Project.Models;
using System.Xml.Linq;

namespace DevCard_Project.Data
{
    public class ProjectDetail
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
               new Project( 1,
    "ApiRepository",
     "سامانه ای جهت سهولت دسترسی به دیتابیس به همراه تمامی جزئیات آن اعم از Spها، Schemaها، Tableها، و... .و نه تنها دسترسی بلکه تمامی اعمالی که امکان اجرای آن روی دیتابیس وجود دارد را شامل می شود و دقیقاً مثل یک محیط مبتنی بر دیتابیس عمل می کند که حاصل دسترنج تیم DarkMode زیرنظر آقای محمدی هستند، می باشد. ",
     "EveryBody",
    "Screenshot 2025-11-17 164341.jpg"),
               new Project(2,
                    " Siban",
                      "این پروژه، جهت انتقال تمامی اطلاعات، عملیات ها، جداول، و... مربوط به سامانه همراه که سابقاً  (در حال حاضر) در تمامی شعب بانک رفاه کارگران در دسترس بوده اما به جهت نوآوری و مدرن سازی آن به سامانه سیبان تغییر پیدا کرده است. بنده نیز جزء کوچکی از این پیشبرد را به عهده دارد. ",
                      "EveryBody",
                      "Screenshot 2025-11-17 164455.jpg"
                 )
            };
        }

        public static Project GetProjectBy(int id)
        {
            return GetProjects().FirstOrDefault(p => p.Id == id);
        }
    }
}