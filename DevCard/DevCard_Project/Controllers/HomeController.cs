using System.Diagnostics;
using System.Net.Mime;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        public FileResult Contact(IFormCollection form)
        {
            var a = form.TryGetValue("name", out var name);
            var b = form.TryGetValue("email", out var email);
            var c = form.TryGetValue("service", out var service);
            var d = form.TryGetValue("message", out var message);

            var fileByte = System.IO.File.ReadAllText("wwwroot/json.txt");
            fileByte = fileByte.Replace("{name}", name).Replace("{email}", email).Replace("{service}", service).Replace("{message}", message);

            var fileName = "Result.txt";
            var bytes = System.Text.Encoding.UTF8.GetBytes(fileByte);

            return File(bytes, MediaTypeNames.Text.RichText, fileName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
