using Cargo_Shipment.Data;
using Cargo_Shipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo_Shipment.Controllers
{
    public class HomeController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();
        public ActionResult Index()
        {
            return View(db.Branches.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Price()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OrderStatus(string TrackingID)
        {
            if (TrackingID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            ConsignmentBook Tracking_ID = db.ConsignmentBooks.Where(tid => tid.CNIC == TrackingID).FirstOrDefault();

            if (Tracking_ID == null)
            {
                ModelState.AddModelError("", "Record Not Found Against " + TrackingID + " Tracking Number");
            }

            return View(Tracking_ID);
        }
    }
}