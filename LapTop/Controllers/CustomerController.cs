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
        //withought entity framework
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
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext; // Tạo phiên bản LapTopContext
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

        public ActionResult Details(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
            ViewData["Customer"] = context.GetDataCustomer(makh);
            return View(context.GetDataCustomer(makh));
        }

        public ActionResult Edit(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
            ViewData["Customer"] = context.GetDataCustomer(makh);
            return View(context.GetDataCustomer(makh));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string makh, Customer kh)
        {

            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
            //ViewBag.greet = makh;
            if (context.UpdateCustomer(kh) != 0)
            {
                return Redirect("/Customer/Index");
            }
            return Redirect("/Customer/Index");
        }

        public ActionResult Delete(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;
            ViewData["Customer"] = context.GetDataCustomer(makh);
            if (context.DeleteCustomer(makh) != 0)
            {
                return Redirect("/Customer/Index");
            }
            return Redirect("/Customer/Index");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(string makh, Customer kh)
        //{
        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(LapTop.Models.LapTopContext)) as LapTopContext;

        //    if (context.DeleteCustomer(kh) != 0)
        //    {
        //        return Redirect("/Customer/Index");
        //    }
        //    return Redirect("/Customer/Index");
        //}
    }
}
