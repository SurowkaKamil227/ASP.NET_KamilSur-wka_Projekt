using Microsoft.AspNetCore.Mvc;

namespace LabPJ.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
