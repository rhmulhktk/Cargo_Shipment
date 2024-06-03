using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cargo_Shipment.Data
{
    public class Cargo_ShipmentContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Cargo_ShipmentContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Cargo_Shipment.Models.ShipAppoinment> ShipAppoinments { get; set; }

        public System.Data.Entity.DbSet<Cargo_Shipment.Models.ConsignmentBook> ConsignmentBooks { get; set; }

        public System.Data.Entity.DbSet<Cargo_Shipment.Models.Branch> Branches { get; set; }
    }
}
