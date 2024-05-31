using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cargo_Shipment.Models
{
    public class ConsignmentBook
    {
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your C.N.I.C Number")]
        [Display(Name = "C.N.I.C Number")]
        public string CNIC { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your Full Name")]
        [Display(Name = "Consignee Full Name")]
        public string Consignee { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Your Full Name")]
        [Display(Name = "Shiper Full Name")]
        public string Shiper { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Receiver C.N.I.C Number")]
        [Display(Name = "Shiper C.N.I.C")]
        public string ShiperCNIC { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Shiper Email")]
        public string ShiperEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Your Contact Number")]
        [Display(Name = "Shiper Contact Number")]
        public string ShiperPhone { get; set; }

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
        [Display(Name = "Consignee Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Your Contact Number")]
        [Display(Name = "Consignee Contact Number")]
        public string ConsigneePhone { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Shipment Details")]
        public string Desc { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Description about Current Status")]
        [Display(Name = "Current Status")]
        public string CurrentStatus { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Booking Date")]
        public DateTime BDate { get; set; }

    }
}