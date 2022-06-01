using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models.Languages;
using WebApplication1.Models.People;

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
            ViewBag.People = new SelectList(dbContext.People,"Id", "Name");
            ViewBag.Languages = new SelectList(dbContext.Languages, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Assign(int personId, int languageId)
        {
            var alreadyknownlanguage = dbContext.PersonLanguage.Find(personId, languageId);
            if(alreadyknownlanguage == null)
            {
                dbContext.PersonLanguage.Add(new PersonLanguage { PersonId = personId, LanguageId = languageId });
                dbContext.SaveChanges();
                TempData["Message"] = $"Language Assigned";

            }
            else
            {
                TempData["Message"] = $"Language Not Assigned, Language is already known by person";
            }

            return RedirectToAction("Index");
        }

        public IActionResult Unassign(int personId, int languageId)
        {
            var toDelete = dbContext.PersonLanguage.Where(o => o.PersonId == personId).Where(o => o.LanguageId == languageId).Single();
            dbContext.PersonLanguage.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int languageId)
        {
            var toDelete = dbContext.Languages.Where(l => l.Id == languageId).Single();
            if(toDelete != null)
            {
                dbContext.Languages.Remove(toDelete);
                dbContext.SaveChanges();
                TempData["Message"] = "Language Successfully Deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
