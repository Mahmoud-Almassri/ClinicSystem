using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Visit
    {
        public int ID { get; set; }
        public int VisitType { get; set; }
        public string VisitReason { get; set; }
        public DateTime NextVisitDate { get; set; }
        public string DoctorReporte { get; set; }
        public double BPSystolic { get; set; }
        public double BPDiatolic { get; set; }
        public double TemPrature { get; set; }
        public double Plus { get; set; }
         public double ResipatoryRate { get; set; }
         public double Weight { get; set; }
         public double Height { get; set; }

         public List<Sysptom> sysptom { get; set; }
         public List<Diagonostics> diagonostics { get; set; }
         public List<Prescription> prescription { get; set; }
         public List<TestOrder> testOrder { get; set; }
         [ForeignKey("Visit_Patiant")]
         public int Patiant_ID { get; set; }
         public  Patient Visit_Patiant { get; set; }
         [ForeignKey("Visit_User")]
         public int User_ID { get; set; }
         public Users Visit_User { get; set; }

    }
}
