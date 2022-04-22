using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Patient
    {
        public int ID { get; set; }
        public string PationtNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Country { get; set; }
        public int City { get; set; }
        public string Address { get; set; }
        [ForeignKey("country")]
        public int Country_ID { get; set; }
        public City country { get; set; }
        [ForeignKey("city")]
        public int City_ID { get; set; }
        public Country city { get; set; }
        public List<Visit> visit { get; set; }
        public List<Reservation> reservation { get; set; }

    }
}
