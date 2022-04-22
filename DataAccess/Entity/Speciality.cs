using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Speciality
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Reservation> reservation { get; set; }
        public List<Users> user { get; set; }
    }
}
