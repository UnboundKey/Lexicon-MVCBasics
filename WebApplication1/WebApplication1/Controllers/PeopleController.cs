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
        public IActionResult Index()
        {
            PeopleViewModel pwm = new PeopleViewModel();
            return View(pwm);
        }

        public IActionResult Create()
        {
            return Index();
        }
    }
}
