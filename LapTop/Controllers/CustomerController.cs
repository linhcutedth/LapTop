using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LapTop.Models;

namespace LapTop.Controllers
{
    public class CustomerController : Controller
    {
        //public IActionResult Index()
        //{
        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
        //    return View(context.GetCustomer());
        //}


        //public IActionResult Search(string search)
        //{
        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
        //    return View(context.SearchCustomer(search));
        //}

        public IActionResult Index(string search)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
            return View(context.SearchCustomer(search));
        }

        [HttpGet]
        public ActionResult CreateCustomer()
        {
            var model = new Customer();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer(Customer kh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;

            if (context.CreateCustomer(kh) != 0)
            {
                return Redirect("/Customer/Index");
            }
            return Redirect("/Customer/Index");
        }

    }
}
