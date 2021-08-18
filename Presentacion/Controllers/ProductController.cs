using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using Business;
using Business.Business_Maintenance;

namespace Presentacion.Controllers
{
    public class ProductController : Controller
    {
        Product_Business_Data BusinessProduct = new Product_Business_Data();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
    }
}