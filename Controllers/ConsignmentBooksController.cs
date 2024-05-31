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
    public class ConsignmentBooksController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();

        // GET: ConsignmentBooks
        public ActionResult Index()
        {
            return View(db.ConsignmentBooks.ToList());
        }

        // GET: ConsignmentBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsignmentBook consignmentBook = db.ConsignmentBooks.Find(id);
            if (consignmentBook == null)
            {
                return HttpNotFound();
            }
            return View(consignmentBook);
        }

        // GET: ConsignmentBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsignmentBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CNIC,Consignee,Shiper,ShiperCNIC,ShiperEmail,ShiperPhone,Origin,Destination,Location,Email,ConsigneePhone,Desc,CurrentStatus,BDate")] ConsignmentBook consignmentBook)
        {
            if (ModelState.IsValid)
            {
                db.ConsignmentBooks.Add(consignmentBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consignmentBook);
        }

        // GET: ConsignmentBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsignmentBook consignmentBook = db.ConsignmentBooks.Find(id);
            if (consignmentBook == null)
            {
                return HttpNotFound();
            }
            return View(consignmentBook);
        }

        // POST: ConsignmentBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CNIC,Consignee,Shiper,ShiperCNIC,ShiperEmail,ShiperPhone,Origin,Destination,Location,Email,ConsigneePhone,Desc,CurrentStatus,BDate")] ConsignmentBook consignmentBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consignmentBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consignmentBook);
        }

        // GET: ConsignmentBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsignmentBook consignmentBook = db.ConsignmentBooks.Find(id);
            if (consignmentBook == null)
            {
                return HttpNotFound();
            }
            return View(consignmentBook);
        }

        // POST: ConsignmentBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConsignmentBook consignmentBook = db.ConsignmentBooks.Find(id);
            db.ConsignmentBooks.Remove(consignmentBook);
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
