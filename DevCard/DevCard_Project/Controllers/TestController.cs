using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mime;
using System.Xml.Linq;

namespace DevCard_Project.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public ViewResult Index()
        //{
        //    return View("Asli");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Header");
        //}

        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/me.png");
        //    var filename = "TestFile.png";
        //    return File(fileByte, MediaTypeNames.Image.Jpeg, filename);
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h1>Hi Everyone, Nice To Meet You", "Text/html");
        //}

        //public EmptyResult Index() 
        //{
        //    return new EmptyResult();   
        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 1,
        //        name = "Ali",
        //        family = "azami",
        //        age = 28,
        //        job = "Developer"
        //    });

        //}

        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('Salam Salam, Zendegi Salam!!!')");
        //}

        //public class JavaScriptResult : ContentResult
        //{
        //    public JavaScriptResult(string content)
        //    {
        //        Content = content;
        //        ContentType = "application/javascript";
        //    }

        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.daneshrefah.ir");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact","Home");
        //}

        public IActionResult Index()
        { 
        //return new OkResult();
        //return new UnauthorizedResult();
        //return new BadRequestResult();
        //return new NoContentResult();
        return new NotFoundResult();
        }
    }
}


