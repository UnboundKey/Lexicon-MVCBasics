using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.People;

namespace WebApplication1.Controllers
{
    public class AJAXController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Get(int personid)
        {
            PeopleViewModel wm = new PeopleViewModel();
            Person resultPerson = null;
            return InputResponseView(personid, wm, ref resultPerson);
        }

        private IActionResult InputResponseView(int personid, PeopleViewModel wm, ref Person resultPerson)
        {
            if (ModelState.IsValid)
            {
                if (personid > wm.getPeople().Count)
                {
                    TempData["Message"] = $"Could not find person with id {personid}, make sure you enter a valid id before continuing";
                    return PartialView("/Views/People/_Person.cshtml");
                }

                foreach (Person p in wm.getPeople())
                {
                    if (p.Id == personid)
                    {
                        resultPerson = p;
                        break;
                    }
                    
                }
                if (resultPerson == null)
                {
                    TempData["Message"] = $"Could not find detail about Person with ID: {personid}";
                    return PartialView("/Views/AJAX/_Message.cshtml");
                }
                return PartialView("/Views/People/_Person.cshtml", resultPerson.Id);
            }
            TempData["Message"] = "Invalid Input in form, please make sure it is filled correctly before submitting";
            return PartialView("/Views/AJAX/_Message.cshtml");
        }

        [HttpPost]
        public IActionResult Delete(int personid)
        {
            Person.Delete(personid, this);
            return PartialView("/Views/AJAX/_Message.cshtml");

        }

        public IActionResult GetAll()
        {
            return PartialView("/Views/People/_Person.cshtml");
        }

    }
}
