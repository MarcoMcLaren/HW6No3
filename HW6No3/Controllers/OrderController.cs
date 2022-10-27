using HW6No3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW6No3.Controllers
{
    public class OrderController : Controller
    {
        public BikeStoresEntities db = new BikeStoresEntities();
        // GET: Order
        public ActionResult Index()
        {
            return View(db.orders.ToList());
        }
    }
}