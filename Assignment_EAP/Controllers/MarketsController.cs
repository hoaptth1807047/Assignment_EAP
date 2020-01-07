using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_EAP.Models;

namespace Assignment_EAP.Controllers
{
    public class MarketsController : Controller
    {
        private Assignment_EAPContext db = new Assignment_EAPContext();

        public ActionResult Index()
        {
            return View(db.Markets.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Name, Description, CreatedAt, UpdatedAt, Status")] Market market)
        {
            if (ModelState.IsValid)
            {
                db.Markets.Add(market);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(market);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}