using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
