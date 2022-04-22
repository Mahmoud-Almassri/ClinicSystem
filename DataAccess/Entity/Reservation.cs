using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Reservation
    {
        public int ID { get; set; }
        public string PationtName { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public int Status { get; set; }
        public int Dotor { get; set; }
        [ForeignKey("Reservation_Speciality")]
        public int Speciality_ID { get; set; }
        public Speciality Reservation_Speciality { get; set; }

        [ForeignKey("Reservation_Patiant")]
        public int ptiant_ID { get; set; }
        public Patient Reservation_Patiant { get; set; }
        [ForeignKey("Reservation_User")]
        public int User_ID { get; set; }
        public Users Reservation_User { get; set; }

    }
}
