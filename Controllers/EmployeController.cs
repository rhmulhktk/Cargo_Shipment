using Cargo_Shipment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo_Shipment.Controllers
{
    public class EmployeController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();
        // GET: Employe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerAppoinmnts()
        {
            return View(db.ShipAppoinments.ToList());
        }
    }
}