using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Resume.Models
{
    public class ResumeMain
    {
        public int ID { get; set; }             //Key

        [Display(Name = "Resume Name")]
        public string ResName { get; set; }     //Resume Name

        [Display(Name = "Description")]
        public string Descr { get; set; }       //Description

        [Display(Name = "Resume Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ResDate { get; set; }   //Date

        [Display(Name = "My Name")]
        public string MyName { get; set; }

        [Display(Name = "Email Addr")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Objective")]
        public string Objective { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }   //Date

    }
}
