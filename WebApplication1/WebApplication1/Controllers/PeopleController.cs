using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.People;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        PeopleViewModel pwm = new PeopleViewModel();

        public IActionResult Index()
        {
            return View(pwm);
        }

        [HttpPost]
        public IActionResult Index(string searchTerm)
        {
            
            pwm.searchTerm = searchTerm;
            return View(pwm);
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel cpwm)
        { 
           if (ModelState.IsValid)
            {
                cpwm.Create();
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
            Person.Delete(personId,this);
            return RedirectToAction("Index");
        }
    }
}
