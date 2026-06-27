using Microsoft.AspNetCore.Mvc;

namespace _04Demo_AttributeBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]  // "/"
        [Route("Index")]// "/Ho                                                                                                                                                                                                                    me/Index"
        //[Route("~/")] // "/Home"
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]//"/Home/About"
        public IActionResult About()
        {
            return View();
        }
    }
}
