using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTimetabling.Models
{
    public class Staff
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public float Fraction { get; set; }
        public virtual ICollection<Remission> Remissions { get; set; }
    }
}