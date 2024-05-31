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
    public class AppoinmentsController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();

        // GET: Appoinments
        public ActionResult Index()
        {
            return View(db.ShipAppoinments.ToList());
        }

        // GET: Appoinments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipAppoinment shipAppoinment = db.ShipAppoinments.Find(id);
            if (shipAppoinment == null)
            {
                return HttpNotFound();
            }
            return View(shipAppoinment);
        }

        // GET: Appoinments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appoinments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Consignee,CNIC,Origin,Destination,Location,Email,Phone,Desc,BDate,BTime")] ShipAppoinment shipAppoinment)
        {
            if (ModelState.IsValid)
            {
                db.ShipAppoinments.Add(shipAppoinment);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(shipAppoinment);
        }

        // GET: Appoinments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipAppoinment shipAppoinment = db.ShipAppoinments.Find(id);
            if (shipAppoinment == null)
            {
                return HttpNotFound();
            }
            return View(shipAppoinment);
        }

        // POST: Appoinments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Consignee,Origin,Destination,Location,Email,Phone,Desc,BDate")] ShipAppoinment shipAppoinment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shipAppoinment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shipAppoinment);
        }

        // GET: Appoinments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShipAppoinment shipAppoinment = db.ShipAppoinments.Find(id);
            if (shipAppoinment == null)
            {
                return HttpNotFound();
            }
            return View(shipAppoinment);
        }

        // POST: Appoinments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShipAppoinment shipAppoinment = db.ShipAppoinments.Find(id);
            db.ShipAppoinments.Remove(shipAppoinment);
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
