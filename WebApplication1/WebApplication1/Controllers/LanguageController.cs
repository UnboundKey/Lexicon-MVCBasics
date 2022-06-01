using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models.Languages;

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
            var dbResult = dbContext.Languages.Include("People.Person").ToList();
            return View(dbResult);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Language language)
        {
            
            dbContext.Languages.Add(language);
            dbContext.SaveChanges();
            TempData["Message"] = $"Language {language.Name} Created";
            return RedirectToAction("Index");
        }

        public IActionResult Assign()
        {
            return View();
        }
    }
}
