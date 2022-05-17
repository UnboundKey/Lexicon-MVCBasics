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
            foreach(Person p in wm.getPeople())
            {
                if(p.Id == personid)
                {
                    resultPerson = p;
                } else if (p == null)
                {
                   resultPerson = wm.getPeople().ElementAt(0);
                }
            }
            return PartialView("/Views/People/_Person.cshtml", resultPerson);
        }

    }
}
