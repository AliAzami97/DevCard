using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;
using DevCard_Project.Data;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_Project.Controllers
{
    //[Route("/teste/contacte/{action}")]
    //[Route("/teste/contacte")]
    public class HomeController : Controller
    {
        private readonly List<Service> _selectList = new List<Service>
        {
            new Service(1, "Gold"),
            new Service(2, "Silver"),
            new Service(3, "Platin"),
            new Service(4, "nul")
        };
        //[Route("MyIndex")]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        [HttpGet("ContactPage")]
        //[Route("ContactPage/{esm}/{type}/{salsakht}")]
        public IActionResult Contact(string esm, string type, int salsakht)
        {
            var model = new Contact
            {
               Services = new SelectList(_selectList, "Id", "Name")
            };

            //var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public FileResult Contact(IFormCollection form)
        //{
        //    var a = form.TryGetValue("name", out var name);
        //    var b = form.TryGetValue("email", out var email);
        //    var c = form.TryGetValue("service", out var service);
        //    var d = form.TryGetValue("message", out var message);

        //    var fileByte = System.IO.File.ReadAllText("wwwroot/json.txt");
        //    fileByte = fileByte.Replace("{name}", name).Replace("{email}", email).Replace("{service}", service).Replace("{message}", message);

        //    var fileName = "Result.txt";
        //    var bytes = System.Text.Encoding.UTF8.GetBytes(fileByte);

        //    return File(bytes, MediaTypeNames.Text.RichText, fileName);
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_selectList, "Id", "Name", _selectList.FirstOrDefault(x=> x.Id == model.Service).Name);

            if (!ModelState.IsValid)
            {
                ViewBag.Error = "خطا داری، برو درستش کن بیا!";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_selectList, "Id", "Name")
            };
            ViewBag.Success = "آفرین، درسته...";
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult ProjectDetails(int id)
        {
            var model = ProjectDetail.GetProjectBy(id);
            return View(model);
        }
    }
}
