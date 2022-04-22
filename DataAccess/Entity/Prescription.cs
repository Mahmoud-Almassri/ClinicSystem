using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Prescription
    {
        public int ID { get; set; }
        public string DrugName { get; set; }
        public string Strength { get; set; }
        public string DirectionForUse { get; set; }
        public string Quantity { get; set; }
        public string TreatmentDetails { get; set; }
        [ForeignKey("Visit_Prescription")]
        public int Visit_ID { get; set; }
        public Visit Visit_Prescription { get; set; }
    }
}
