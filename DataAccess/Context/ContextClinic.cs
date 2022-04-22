using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using DataAccess.Entity;
namespace DataAccess.Context
{
  public class ContextClinic:DbContext
    {
        public ContextClinic():base("name=ClinicSystem")
        {

        }
        public virtual DbSet<Accessed> Acc { get; set; }
        public virtual DbSet<City> Cit { get; set; }
        public virtual DbSet<Country> Cou { get; set; }
        public virtual DbSet<Diagonostics> Dia { get; set; }
        public virtual DbSet<Group> Gro { get; set; }
        public virtual DbSet<Modules> Mod{ get; set; }
        public virtual DbSet<Patient> Pat { get; set; }
        public virtual DbSet<Prescription> Pre { get; set; }
        public virtual DbSet<Reservation> Res { get; set; }

        public virtual DbSet<Speciality> Spe { get; set; }
        public virtual DbSet<Sysptom> Sys { get; set; }
        public virtual DbSet<TestOrder> Tes { get; set; }
        public virtual DbSet<Users> Use { get; set; }
        public virtual DbSet<Visit> Vis { get; set; }
    }
}
