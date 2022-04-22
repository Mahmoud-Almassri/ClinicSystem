using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Patient> City_Patiant { get; set; }

        [ForeignKey("city_Country")]
        public int City_ID { get; set; }
        public Country city_Country { get; set; }
    }
}
