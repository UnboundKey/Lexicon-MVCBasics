using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.People
{
    public class DeletePersonViewModel
    {

        public static void Delete(int PersonId, Controller controller)
        {
            PeopleViewModel pwm = new PeopleViewModel();
            foreach (Models.Person p in pwm.getPeople())
            {
                if (PersonId == p.Id)
                {
                    pwm.getPeople().Remove(p);
                    controller.TempData["Message"] = "Person Removed Successfully";
                    break;
                }
            }
        }

    }
}
