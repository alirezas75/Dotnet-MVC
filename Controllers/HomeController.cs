using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }
    }
}