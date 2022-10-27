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


        [HttpPost]
        public ActionResult Index(DateTime date)
        {
            if (date.Equals(null))
            {
                return View(db.orders.ToList());
            }
            else
            {
                return View(db.orders.Where(x => x.order_date == date).ToList());
            }
           
        }
    }
}