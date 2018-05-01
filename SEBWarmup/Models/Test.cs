using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEBWarmup.Models
{
    public class SEBTest
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "The Test Name")]
        public string name { get; set; }




    }
}