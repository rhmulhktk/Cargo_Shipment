using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cargo_Shipment.Models
{
    public class UpdatNews
    {
        public int ID { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please Enter Update News")]
        [Display(Name = "News for Employees")]
        public string News { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NewsDate { get; set; }
    }
}