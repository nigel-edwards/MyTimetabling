using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTimetabling.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public String Speciality { get; set; }
    }
}