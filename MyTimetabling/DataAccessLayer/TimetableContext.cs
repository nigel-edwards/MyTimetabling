using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MyTimetabling.Models;

namespace MyTimetabling.DataAccessLayer
{
    public class TimetableContext : DbContext
    {
        public TimetableContext() :  base("TimetableConnectionString")
        {
            //Database.SetInitializer<TimetableContext>(new CreateDatabaseIfNotExists<TimetableContext>());

            //Database.SetInitializer<TimetableContext>(new DropCreateDatabaseIfModelChanges<TimetableContext>());
            //Database.SetInitializer<TimetableContext>(new DropCreateDatabaseAlways<TimetableContext>());
            //Database.SetInitializer<TimetableContext>(new TimetableInitialiser());
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Remission> Remissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}