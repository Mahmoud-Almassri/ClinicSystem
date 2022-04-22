using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using DataAccess.GenericRepository;

namespace BusnissLogic.SpecificRepository
{
  public  interface IUserReposotory
    {
      List<Group> FillGroup();
      List<Speciality> FillSpeciality();
      void Insert(Users user);
      void Remove(int user);
      void Update(Users mod);

      List<Users> FillUser();
      Users Edit(int id);
    }
}
