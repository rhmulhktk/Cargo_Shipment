using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cargo_Shipment.Models
{
    public class ShipAppoinment
    {
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please Enter Your Full Name")]
        [Display(Name ="Full Name")]
        public string Consignee  { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your Origin")]
        [Display(Name = "Origin")]
        public string Origin { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Enter Your Destination Address")]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Enter Your Address")]
        [Display(Name = "Address")]
        public string Location { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Your Contact Number")]
        [Display(Name ="Contact Number")]
        public string Phone { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Description about Shipment")]
        [Display(Name = "Shipment Details")]
        public string Desc { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime BTime { get; set; }
    }
}