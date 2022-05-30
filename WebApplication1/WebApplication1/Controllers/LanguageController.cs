using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class LanguageController : Controller
    {

        ApplicationDbContext dbContext;
        public LanguageController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var dbResult = dbContext.Languages.Include("People").ToList();
            return View(dbResult);
        }
    }
}
