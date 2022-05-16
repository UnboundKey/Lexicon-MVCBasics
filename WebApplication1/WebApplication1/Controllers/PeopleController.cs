using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
           if(ModelState.IsValid)
            {
               
            }
            return Index();
        }

        public IActionResult Delete(int personId)
        {
            foreach (Models.Person p in pwm.getPeople())
            {
                if (personId == p.Id)
                {
                    pwm.getPeople().Remove(p);
                    break;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
