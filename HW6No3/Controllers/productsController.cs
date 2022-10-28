using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW6No3.Models;
using PagedList.Mvc;
using PagedList;
using System.Threading.Tasks;

namespace HW6No3.Controllers
{
    public class productsController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();

        // GET: products
        public ActionResult Index(int ? i)
        {
            var products = db.products.Include(p => p.brands).Include(p => p.categories);
            return View(products.ToList().ToPagedList(i ?? 1, 10));
        }

        [HttpPost]
        public ActionResult Index(string search, int? i)
        {
            var products = db.products.Include(p => p.brands).Include(p => p.categories);
            return View(products.Where(x => x.product_name.Contains(search)).ToList().ToPagedList(i ?? 1, 10)); ;
        }

        public ActionResult Add()
        {
            return PartialView();
        }

        public ActionResult Edit()
        {
            return PartialView();
        }

        public ActionResult Delete()
        { 
            return PartialView();
        }

        public ActionResult Details()
        {
            return PartialView();
        }








    }
}
