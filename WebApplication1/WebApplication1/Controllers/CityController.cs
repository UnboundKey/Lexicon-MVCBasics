﻿using Microsoft.AspNetCore.Mvc;
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
            var dbResult = dbContext.Cities.ToList();
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
    }
}
