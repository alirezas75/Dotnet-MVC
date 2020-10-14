using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}