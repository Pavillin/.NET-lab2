using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        //GET: Product/Details
        public ActionResult Details(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}