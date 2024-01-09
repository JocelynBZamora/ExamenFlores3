using ExamenFlores3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFlores3.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
    }
}
