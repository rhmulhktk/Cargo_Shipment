using Cargo_Shipment.Data;
using Cargo_Shipment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cargo_Shipment.Controllers
{


    [Authorize]
    public class AdminController : Controller
    {
        private Cargo_ShipmentContext db = new Cargo_ShipmentContext();

        private ApplicationDbContext apuser = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Employee = apuser.Users.Count();
            ViewBag.Shipment = db.ConsignmentBooks.Count();
            ViewBag.Branch = db.Branches.Count();
            ViewBag.OnlineBook = db.ShipAppoinments.Count();
            return View();
        }

        public ActionResult ConsignmentList()
        {
            return View(db.ConsignmentBooks.ToList());
        }
    }
}