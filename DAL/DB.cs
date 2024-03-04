using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;

namespace DAL
{
    public class DB:DbContext
    {
        public DB() : base("constr")
        { }

        public DbSet<Patiant> Patiants { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Files> Filess { get; set; }
  
        public DbSet<Servieces> Serviecess { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Noabat> Noabats { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Insuarance> Insuarances { get; set; }
        public DbSet<Tariffe> Tariffes { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<AccessGroup> AccessUserGroups { get; set; }
        public DbSet<Savabegh> Savabeghs { get; set; }
        public DbSet<ShomareParvande> ShomareParvandes { get; set; }
        public DbSet<Remember> Remembers { get; set; }

        public DbSet<Ghobooz> Ghoboozs { get; set; }
        public DbSet<Time> Times { get; set; }

        public DbSet<Date> Dates { get; set; }
     //   public DbSet<TimeDates> TimeDates { get; set; }

    }
}
