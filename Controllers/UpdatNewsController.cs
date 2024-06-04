using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cargo_Shipment.Data;
using Cargo_Shipment.Models;

namespace Cargo_Shipment.Controllers
{
    public class UpdatNewsController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();

        // GET: UpdatNews
        public ActionResult Index()
        {
            return View(db.UpdatNews.ToList());
        }

        // GET: UpdatNews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpdatNews updatNews = db.UpdatNews.Find(id);
            if (updatNews == null)
            {
                return HttpNotFound();
            }
            return View(updatNews);
        }

        // GET: UpdatNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UpdatNews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,News,NewsDate")] UpdatNews updatNews)
        {
            if (ModelState.IsValid)
            {
                db.UpdatNews.Add(updatNews);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(updatNews);
        }

        // GET: UpdatNews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpdatNews updatNews = db.UpdatNews.Find(id);
            if (updatNews == null)
            {
                return HttpNotFound();
            }
            return View(updatNews);
        }

        // POST: UpdatNews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,News,NewsDate")] UpdatNews updatNews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(updatNews).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(updatNews);
        }

        // GET: UpdatNews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpdatNews updatNews = db.UpdatNews.Find(id);
            if (updatNews == null)
            {
                return HttpNotFound();
            }
            return View(updatNews);
        }

        // POST: UpdatNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UpdatNews updatNews = db.UpdatNews.Find(id);
            db.UpdatNews.Remove(updatNews);
            db.SaveChanges();
            return RedirectToAction("Index");
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
