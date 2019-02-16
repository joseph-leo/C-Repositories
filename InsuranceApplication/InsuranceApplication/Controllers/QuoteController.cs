using System;
using InsuranceApplication.ViewModels;
using InsuranceApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceApplication.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddQuote(string firstName, string lastName, string emailAddress, DateTime birthDay, int year, string make, string model,
            bool dui, int tickets, string coverage)
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var customer = new Customer()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress,
                    BirthDay = birthDay,
                    Dui = dui,
                    Tickets = tickets,
                    Coverage = coverage
                };
                db.Customers.Add(customer);

                var car = new Car()
                {
                    Year = year,
                    Make = make,
                    Model = model,
                    CustomerId = customer.Id
                };
                db.Cars.Add(car);

                decimal quoteAmount = 50.00m;
                TimeSpan timeSpan = DateTime.Now - birthDay;
                int age = timeSpan.Days / 365;
                
                if (age < 18)
                {
                    quoteAmount += 100;
                }
                else if (age < 25)
                {
                    quoteAmount += 25;
                }
                else if (age > 100)
                {
                    quoteAmount += 25;
                }

                if (year < 2000)
                {
                    quoteAmount += 25;
                }
                else if (year > 2015)
                {
                    quoteAmount += 25;
                }

                if (make.ToLower() == "porsche")
                {
                    quoteAmount += 25;
                    if (model.ToLower() == "911 carrera")
                    {
                        quoteAmount += 25;
                    }
                }

                for (int i = 0; i < tickets; i++)
                {
                    quoteAmount += 10;
                }

                if (dui == true)
                {
                    quoteAmount *= 1.25m;
                }

                if (coverage == "full")
                {
                    quoteAmount *= 1.50m;
                }


                var quote = new Quote()
                {
                    QuoteAmount = quoteAmount,
                    CustomerId = customer.Id
                };
                db.Quotes.Add(quote);

                var quoteVm = new QuoteVm()
                {
                    Quote = quoteAmount
                };


                db.SaveChanges();

                return View("YourQuote", quoteVm);
            }
            
        }

    }
}