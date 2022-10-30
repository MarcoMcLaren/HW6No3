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
//using SimpleAsynAjax.Models;
using Newtonsoft.Json;

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
            return View(products.Where(x => x.product_name.Contains(search)).ToList().ToPagedList(i ?? 1, 10));
        }

        /// <summary>
        /// Display all the modals
        /// </summary>
        public ActionResult Add()
        {
            return PartialView();
        }


        [HttpPost]
        public ActionResult Edit(int customerId)
        {
            return PartialView("Edit", db.products.Where(x => x.product_id == customerId).ToList());
        }

        [HttpPost]
        public ActionResult Delete(int customerId)
        {
            return PartialView("Delete", db.products.Where(x => x.product_id == customerId).ToList());

        }

        [HttpPost]
        public ActionResult Details(int customerId)
        {
            return PartialView("Details", db.products.Where(x => x.product_id == customerId).ToList());
        }

/// <summary>
/// Officially CRUD database
/// </summary>

        [HttpPost]
        public ActionResult AddProduct( products request)
        {

            db.products.Add(request);
            db.SaveChanges();
            return Json(request);

            //try
            //{
            //    db.products.Add(request);
            //    db.SaveChanges();
            //    string message = "SUCCESS";
            //    return Json(new { Message = message, JsonRequestBehavior.AllowGet });
            //}
            //catch (Exception)
            //{
            //    return RedirectToAction("Index");
            //}
        }

    }
}
