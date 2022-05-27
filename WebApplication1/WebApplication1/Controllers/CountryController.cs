using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CountryController : Controller
    {

        ApplicationDbContext dbContext;
        public CountryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var databaseResult = dbContext.Countries.Include("Cities").ToList();
            return View(databaseResult);
        }
    }
}
