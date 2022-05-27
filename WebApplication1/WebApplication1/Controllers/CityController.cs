using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CityController : Controller
    {
        ApplicationDbContext dbContext;
        public CityController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var dbResult = dbContext.Cities.Include("People").Include("Country").ToList();
            return View(dbResult);
        }

        public IActionResult CreateCity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCity(City city)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(city);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Please make sure everything is filed in correctly and try again";
            return RedirectToAction("CreateCity");
        }

        public IActionResult DeleteCity(int CityId)
        {
            var toDelete = dbContext.Cities.Include("People").Where(p => p.Id == CityId).Single<City>();

            if (toDelete != null)
            {
                if (!toDelete.People.Any())
                {
                    dbContext.Cities.Remove(toDelete);
                    dbContext.SaveChanges();
                    TempData["Message"] = "City Removed Successfully";
                    return RedirectToAction("Index");
                }
                TempData["Message"] = "Could not remove city, Can only remove cities without people";

            }
            else
            {
                TempData["Message"] = "Could not remove City";
            };
            return RedirectToAction("Index");
        }
    }
}
