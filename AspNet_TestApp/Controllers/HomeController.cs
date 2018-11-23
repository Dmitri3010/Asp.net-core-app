using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNet_TestApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;

namespace AspNet_TestApp.Controllers
{
    public class HomeController : Controller
    {
        ServicesContext db;
        public HomeController(ServicesContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Services.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        [HttpGet]
       public IActionResult Buy(int id)
        {
            ViewBag.ServiceId = id;
            return View();
        }
        [HttpPost]
        public IActionResult randomName(Order order)
        {
            var tex = "";
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                tex = "Заказ оформлен. Спасибо";
            }
            catch(Exception ex)
            {
                tex = "Данное время занято, выберите пожалуйста другое";
            }

            ViewData["Message"] = tex;

            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }


    }
}
