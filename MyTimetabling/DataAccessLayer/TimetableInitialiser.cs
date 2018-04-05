using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTimetabling.Models;

namespace MyTimetabling.DataAccessLayer
{
    public class TimetableInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<TimetableContext>
    //public class TimetableInitialiser : System.Data.Entity.DropCreateDatabaseAlways<TimetableContext>
    {
        
        protected override void Seed(TimetableContext context)
        {
            var students = new List<Staff>
            {
                new Staff{Fname="Nigel",Lname="Edwards",Fraction=0.6F},
                new Staff{Fname="Paula",Lname="Avey",Fraction=1.0F},
                new Staff{Fname="Chris",Lname="Stanhope",Fraction=1.0F},
                new Staff{Fname="Michael",Lname="Chopping",Fraction=0.6F},
                new Staff{Fname="Liz",Lname="Thompson",Fraction=0.6F},
                new Staff{Fname="Tracy",Lname="Fulcher",Fraction=1.0F},
            };
            students.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room{Name="Q602",Capacity=20,Speciality="Networking Lab - HE students only"},
                new Room{Name="Q603",Capacity=20,Speciality="Games Development Room - no external bookings"},
                new Room{Name="Q604",Capacity=20,Speciality="Genral Games Room"},
                new Room{Name="Q605",Capacity=20,Speciality="Make & Break Lab - no external bookings"},
                new Room{Name="Q611",Capacity=20,Speciality="General Teaching Room"},
                new Room{Name="Q617",Capacity=22,Speciality="General Teaching Room"},
                new Room{Name="Q618",Capacity=22,Speciality="General Teaching Room"}
            };
            rooms.ForEach(s => context.Rooms.Add(s));
            context.SaveChanges();

            var remissions = new List<Remission>
            {
                new Remission{Description="Level 1 Course Director",Hours=2},
                new Remission{Description="Level 2 Course Director",Hours=2},
                new Remission{Description="Level 3 Course Director",Hours=3},
                new Remission{Description="Games Course Director",Hours=2},
                new Remission{Description="Degree Course Director",Hours=3},
                new Remission{Description="Lead IV",Hours=2}
            };
            remissions.ForEach(s => context.Remissions.Add(s));
            context.SaveChanges();
        }
    }
}