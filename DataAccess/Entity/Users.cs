using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Users
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePicture { get; set; }
        public int IsDoctor { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime EffictiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
        public List<Visit> visit { get; set; }

        [ForeignKey("User_Speciality")]
        public int Speciality_ID { get; set; }
        public Speciality User_Speciality { get; set; }
        public List<Reservation> reservation  { get; set; }

        [ForeignKey("User_Group")]
        public int Group_ID { get; set; }
        public Group User_Group { get; set; }




    }
}
