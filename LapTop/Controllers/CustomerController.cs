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

    }
}
