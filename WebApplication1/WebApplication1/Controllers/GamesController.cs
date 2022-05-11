using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult NumberGuesser()
        {

            HttpContext.Session.SetInt32("NumberToGuess", new GuessingGameModel().GetNumber());
            return View();
        }
        [HttpPost]
        public IActionResult NumberGuesser(int GuessedNumber)
        {
            if(GuessedNumber == HttpContext.Session.GetInt32("NumberToGuess"))
            {
                ViewBag.Message = $"You won, the number was {HttpContext.Session.GetInt32("NumberToGuess")}. I've picked a new one if you want to continue playing";
                HttpContext.Session.SetInt32("NumberToGuess", new GuessingGameModel().GetNumber());

            } else if (GuessedNumber > HttpContext.Session.GetInt32("NumberToGuess"))
            {
                ViewBag.Message = $"Go Lower";
            }
            else if (GuessedNumber < HttpContext.Session.GetInt32("NumberToGuess"))
            {
                ViewBag.Message = $"Go Higher";
            }
            return View();
        }
    }
}
