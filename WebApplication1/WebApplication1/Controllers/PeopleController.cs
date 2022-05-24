using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.People;


namespace WebApplication1.Controllers
{

public class PeopleController : Controller
    {

        PeopleViewModel pwm = new PeopleViewModel();
        ApplicationDbContext dbContext;
        public PeopleController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;   
        }

        private List<Person> DatabaseResult;
        public object Index()
        {
           DatabaseResult = dbContext.People.ToList();
            

            return View(DatabaseResult);
        }

        [HttpPost]
        public IActionResult Index(string searchTerm)
        {
            pwm.searchTerm = searchTerm;

            DatabaseResult = dbContext.People.Where(b => b.Name.Contains(searchTerm)).ToList();
            DatabaseResult.AddRange(dbContext.People.Where(b => b.City.CityName.Contains(searchTerm)).ToList());

            return View(DatabaseResult);
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel cpwm)
        { 
           if (ModelState.IsValid)
            {
                cpwm.Create(dbContext);
                TempData["Message"] = "Person Created Successfully";
            }
           else
            {
                TempData["Message"] = "Could Not Create Person, Make sure you filled the form correctly";
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int personId)
        {
            Person.Delete(personId,this, dbContext);
            //applicationDb.Remove(personId);
            return RedirectToAction("Index");
        }
    }
}
