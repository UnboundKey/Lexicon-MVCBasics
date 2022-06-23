using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplication1.Data;

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
            var dbResult = dbContext.People.Include("LanguagesLinkObject.Language").Include("PersonCity");

            var jsoned = Json(dbResult, jsonSerializerOptions);

            return jsoned;
        }

        [AllowAnonymous]
        [Route("api/people/{id}")]
        public JsonResult GetByid(int id) {
            var dbResult = dbContext.People.Include("LanguagesLinkObject.Language").Include("PersonCity").Where(p => p.Id == id);
            var jsonData = Json(dbResult, jsonSerializerOptions);
            return jsonData;
        }

    }
}
