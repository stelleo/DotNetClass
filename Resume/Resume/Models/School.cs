using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class School
    {
        public int ID { get; set; }             //Key
        public int EducationID { get; set; }     //Foreign Key to Education
        public string SchoolName { get; set; }
        public string Yr { get; set; }

    }
}
