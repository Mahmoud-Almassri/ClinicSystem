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
    public class ModuleReposotory : IModuleReposotory
    {

        ContextClinic con = new ContextClinic();
        

        public List<Modules> SubModule()
        {
            List<Modules> listMod = new List<Modules>();
           

          var data = from x in con.Mod
                     where x.SubModule == 0
                     select new {x.ID,x.Name };
          foreach (var item in con.Mod)
          {
              Modules mod = new Modules();
              mod.ID = item.ID;
              mod.Name = item.Name;
              listMod.Add(mod);
              
          }
          return listMod;
                       


        }
        public void Insert(Modules mod)
        {
            Generic<Modules> generic = new Generic<Modules>();
            // IModuleReposotory m = new ModuleReposotory();
            generic.Insert(mod);
            generic.Save();


        }


        public void Update(Modules obj)
        {
            
            Generic<Modules> generic = new Generic<Modules>();
            
           
            generic.Update(obj);
            generic.Save();
        }
        

     
             public List<Modules> fill()
        {

            List<Modules> listMod = new List<Modules>();
            var data = from x in con.Mod
                       select  x;
            foreach (var item in data)
            {
                Modules mod = new Modules();
                mod.ID = item.ID;
                mod.Name = item.Name;
                mod.ShortName = item.ShortName;
                mod.Order = item.Order;
                mod.Path = item.Path;
                mod.SubModule = item.SubModule;
                listMod.Add(mod);

            }
            return listMod;
        }
        public void Remove(int obj)
             {
            IGeneric<Modules> gen=new Generic<Modules>();
            //var data = from x in con.Mod
            //           select x.ID;
            //con.Mod.Find(obj);
            gen.Remove(obj);
            gen.Save();
             }



        public Modules Edit(int id)
        {
            IGeneric<Modules> gen = new Generic<Modules>();
            Modules s=gen.Get(id);
            gen.Save();
            return s;
        }


        public List<Modules> Search(string name)
        {
            var data = from x in con.Mod
                       where name == x.Name
                       select x;
            List<Modules> modli = new List<Modules>();
            foreach (var item in data)
            {
                Modules mod = new Modules();
                mod.ID = item.ID;
                mod.Name = item.Name;
                mod.ShortName = item.ShortName;
                mod.Order = item.Order;
                mod.Path = item.Path;
                mod.SubModule = item.SubModule;
                modli.Add(mod);
            }
            return modli;
        }
    }
}