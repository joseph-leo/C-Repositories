using System;
using InsuranceApplication.Models;
using InsuranceApplication.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {

                
                var adminVms = new List<AdminVm>();

                var adminData = (from cust in db.Customers
                           join quote in db.Quotes on cust.Id equals quote.CustomerId
                           select new
                           {
                               cust.FirstName,
                               cust.LastName,
                               cust.EmailAddress,
                               quote.QuoteAmount
                           }).ToList();
                foreach (var entry in adminData)
                {
                    var adminVm = new AdminVm
                    {
                        FirstName = entry.FirstName,
                        LastName = entry.LastName,
                        EmailAddress = entry.EmailAddress,
                        Quote = Convert.ToDecimal(entry.QuoteAmount)
                    };
                    adminVms.Add(adminVm);
                }

                return View(adminVms);
            }
        }
    }
}