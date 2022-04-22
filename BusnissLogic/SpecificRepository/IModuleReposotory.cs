using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using DataAccess.GenericRepository;
namespace BusnissLogic.SpecificRepository
{
   public interface IModuleReposotory
    {
        //void GetAll(ModuleReposotory obj);
        List<Modules> SubModule();
         void Insert(Modules mod);
         void Update(Modules obj);

         void Remove(int obj);
         List<Modules> fill();
         Modules Edit(int id);
         List<Modules> Search(string name);
    }
}
