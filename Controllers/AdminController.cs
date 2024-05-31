using Cargo_Shipment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo_Shipment.Controllers
{

   
    public class AdminController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ConsignmentList()
        {
            return View(db.ConsignmentBooks.ToList());
        }
    }
}