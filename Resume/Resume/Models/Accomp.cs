using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class Accomp
    {
        public int ID { get; set; }             //Key
        public int PositionID { get; set; }     //Foreign Key to Position
        public int AccompID { get; set; }       //Foreign Key to Accomp(lishment)
        public string AccompText { get; set; }

    }
}
