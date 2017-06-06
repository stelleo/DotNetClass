using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Position
    {
        public int ID { get; set; }             //Key
        public int WorkHistID { get; set; }     //Foreign Key to WorkHist
        public string PosName { get; set; }
        public string PosOrg { get; set; }
        public string PosDates { get; set; }

    }
}
