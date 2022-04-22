using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Patient> Country_Patiant { get; set; }
        public List<City> Cii { get; set; }
    }
}
