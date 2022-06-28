using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication1.Data;
using WebApplication1.Models.People;

namespace WebApplication1.Controllers
{
    public class ReactController : Controller
    {

        JsonSerializerOptions jsonSerializerOptions = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve
                
            };


        ApplicationDbContext dbContext;
        public ReactController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("api/people/all")]
        public JsonResult GetAll()
        {
            //var dbResult = dbContext.PersonLanguage.Include("Person").Include("Language");
            var dbResult = dbContext.People.Include(p => p.PersonCity).Include(p=> p.PersonCity.Country).Include(p=>p.LanguagesLinkObject);
            
            //Clean up database data and send it as json
            List<PersonTO> PeopleCleanedUp = new List<PersonTO>();
            foreach(Person p in dbResult) {
                PeopleCleanedUp.Add(new PersonTO(p));
            }

            var jsoned = Json(PeopleCleanedUp, jsonSerializerOptions);
            return jsoned;
        }

        [AllowAnonymous]
        [Route("api/people/{id}")]
        public JsonResult GetByid(int id) {
            var dbResult = dbContext.People.Include("LanguagesLinkObject.Language").Include("PersonCity").Where(p => p.Id == id);
            //Clean up database result and send it as json
            List<PersonTO> PeopleCleanedUp = new List<PersonTO>();
            foreach(Person p in dbResult) {
                PeopleCleanedUp.Add(new PersonTO(p));
            }

            var jsonData = Json(PeopleCleanedUp, jsonSerializerOptions);
            return jsonData;
        }

    }
}
