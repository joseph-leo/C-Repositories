using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterInfo.Models;
using NewsletterInfo.ViewModels;

namespace NewsletterInfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new NewsletterContext())
            {
                var signUps = db.SignUps.ToList();
                var nameVms = new List<NameVm>();

                foreach (var signup in signUps)
                {
                    var nameVm = new NameVm()
                    {
                        FirstName = signup.FirstName,
                        LastName = signup.LastName,
                        Id = signup.Id
                    };
                    nameVms.Add(nameVm);
                }
                return View(nameVms);
            }          
        }

        public ActionResult MoreInfo(int id)
        {
            using (var db = new NewsletterContext())
            {
                var signUps = db.SignUps.Where(x => x.Id == id).ToList();
                var allEntries = new List<CompleteInfo>();

                foreach (var signUp in signUps)
                {
                    var entry = new CompleteInfo()
                    {
                        FirstName = signUp.FirstName,
                        LastName = signUp.LastName,
                        Id = signUp.Id,
                        Removed = signUp.Removed
                    };
                    allEntries.Add(entry);
                }
                return View(allEntries);
            }
        }
    }
}