using Microsoft.AspNetCore.Mvc;

namespace _05Demo_ReturnTypesOfActionMethods.Controllers
{
    public class DemoController : Controller
    {
        // The most common/ Flexible return type of action method and returning vew from it.
        public IActionResult Index()
        {
            return View();
        }

        // Most common Return Type in old MVC version(Standard .Net)
        public ActionResult About()
        {
            return View();
        }

        // Strongly-typed output : Generic Return type
        public ActionResult<int> GetNumber()
        {
            return 1234;
        }

        public ViewResult M1()
        {
            return View("~/Views/Demo/About.cshtml");
        }

        // /Demo/GetSomething?fnm=Hugh&lnm=Jackman
        public string GetSomething(string fnm, string lnm)
        {
            return $"Hello, {fnm} {lnm}";
        }

        public JsonResult GetData()
        {
            var data = new{ 
                id= 101,
                name = "Peter Parker",
                City="LA"
            };
            return Json(data);
        }

        public StatusCodeResult GetStatus()
        {
            return StatusCode(404);
        }

        public ObjectResult GetObject()
        {
            var obj = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            return new ObjectResult(obj);
        }

        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        // Strongly - typed action method , returning Task object to perform Asynchronus operations
        public async Task<ViewResult> GetResult()
        {
            await Task.Delay(3000);
            return View("~/Views/Demo/About.cshtml");
        }
        public FileResult DownloadPDF()
        {
            var filepath = @"D:\2026\DotNet\IET_Feb_26\WebDemos26\05Demo_ReturnTypesOfActionMethods\Data\quote.pdf";

           var byteArray = System.IO.File.ReadAllBytes(filepath);

            return File(byteArray,"application/pdf", "quote.pdf");
        }
    }
}
