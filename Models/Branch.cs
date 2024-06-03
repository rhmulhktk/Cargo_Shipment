using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cargo_Shipment.Models
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Branch Name")]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Enter Branch Addrss")]
        [Display(Name = "Branch Address")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter Branch Contact Number")]
        [Display(Name = "Branch Contact")]
        public string Contact { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Branch Contact")]
        public string MapUrl { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}