using Cargo_Shipment.Data;
using Cargo_Shipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Cargo_Shipment.Controllers
{
    [Authorize]
    public class EmployeController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();
        // GET: Employe
        public ActionResult Index()
        {
            return View(db.UpdatNews.ToList());
        }

        public ActionResult CustomerAppoinmnts()
        {
            return View(db.ShipAppoinments.ToList());
        }

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
    }
}