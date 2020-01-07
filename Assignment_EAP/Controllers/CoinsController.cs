using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_EAP.Models;

namespace Assignment_EAP.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CoinsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: Coins
        public ActionResult Index(string market, string searchKeyword, string currentFilter)
        {
            var coins = db.Coins.Include(c => c.Market);

            if (searchKeyword == null)
            {
                searchKeyword = currentFilter;
            }


            ViewBag.CurrentFilter = searchKeyword;

            coins = from c in db.Coins select c;
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                coins = coins.Where(s => s.Name.Contains(searchKeyword) && s.MarketId.Contains(market));
            }

            return View(coins.ToList());
        }

        // GET: Coins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Coin coin = db.Coins.Find(id);
            if (coin == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(coin);
        }

        // GET: Coins/Create
        public ActionResult Create()
        {
            ViewBag.MarketId = new SelectList(db.Markets, "Id", "Name");
            return View();
        }

        // POST: Coins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
                "Id, Name, BaseAsset, QuoteAsset, LastPrice, Volumn24h, MarketId, CreatedAt, UpdatedAt, Status")]
            Coin coin)
        {
            if (ModelState.IsValid)
            {
                db.Coins.Add(coin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MarketId = new SelectList(db.Markets, "Id", "Name", coin.MarketId);
            return View(coin);
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