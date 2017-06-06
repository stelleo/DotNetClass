using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class WorkHist
    {
        public int ID { get; set; }             //Key
        public int ResumeMainID { get; set; }     //Foreign Key to Resume
        public string SectionTitle { get; set; }    //presumably 'Work History' or 'Professional Experience'
    }
}
