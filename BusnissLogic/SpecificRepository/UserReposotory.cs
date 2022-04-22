using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using DataAccess.GenericRepository;
using DataAccess.Context;


namespace BusnissLogic.SpecificRepository
{
   public class UserReposotory :IUserReposotory
    {
        public List<Group> FillGroup()
        {
            ContextClinic con = new ContextClinic();
            List<Group> listGrp = new List<Group>();

            var data = from x in con.Gro
                       
                       select new { x.ID, x.Name };
            foreach (var item in con.Gro)
            {
                Group Gro = new Group();
                Gro.ID = item.ID;
                Gro.Name = item.Name;
                listGrp.Add(Gro);

            }
            return listGrp;
                       
        }
        public List<Speciality> FillSpeciality()
        {
            ContextClinic con = new ContextClinic();
            List<Speciality> listsp = new List<Speciality>();

            var data = from x in con.Spe

                       select new { x.ID, x.Name };
            foreach (var item in con.Spe)
            {
                Speciality sp = new Speciality();
                sp.ID = item.ID;
                sp.Name = item.Name;
                listsp.Add(sp);

            }
            return listsp;

        }


        public void Insert(Users user)
        {
         
            Generic<Users> us = new Generic<Users>();
            // IModuleReposotory m = new ModuleReposotory();
            us.Insert(user);
            us.Save();


        
        }
        public void Update(Users us)
        {

            Generic<Users> generic = new Generic<Users>();


            generic.Update(us);


            generic.Save();
        }


        public void Remove(int user)
        {
            IGeneric<Users> us = new Generic<Users>();
            us.Remove(user);
            us.Save();
        }




        public List<Users> FillUser()
        {
            ContextClinic con = new ContextClinic();
            List<Users> UserList = new List<Users>();

            var data = from x in con.Use
                       select x;
            foreach (var item in data)
            {
                Users us = new Users();
                us.ID = item.ID;
                us.FName = item.FName;
                us.LName = item.LName;
                us.Gender = item.Gender;
                us.BirthDate = item.BirthDate;
                us.ProfilePicture = item.ProfilePicture;
                us.IsDoctor = item.IsDoctor;
                us.PhoneNumber = item.PhoneNumber;
                us.Email = item.Email;
                us.Address = item.Address;
                us.UserName = item.UserName;
                us.Password = item.Password;
                us.ConfirmPassword = item.ConfirmPassword;
                us.EffictiveDate = item.EffictiveDate;
                us.ExpiryDate = item.ExpiryDate;
                us.Status = item.Status;
                us.StatusDate = item.StatusDate;

                UserList.Add(us);
            }
            return UserList;

        }


        public Users Edit(int id)
        {
            IGeneric<Users> us = new Generic<Users>();
            Users s= us.Get(id);
            us.Save();
            return s;
        }
    }
}
