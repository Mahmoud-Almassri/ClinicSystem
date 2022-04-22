using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess.Entity;
using BusnissLogic.SpecificRepository;
using DataAccess.GenericRepository;

namespace ClinicApi.Controllers
{
    public class ModuleController : ApiController
    {
        IModuleReposotory objrep = new ModuleReposotory();

        [HttpGet]
        [Route("api/Module/FillSubModules")]

        public List<Modules> FillSubModules()
        {
          
            return objrep.SubModule();

        }



        [HttpPost]
        [Route("api/Module/InsertNewUser")]
      public void Insert(Modules mod)
      {



          objrep.Insert(mod);
            
          
      }
        [HttpPost]
        [Route("api/Module/Update")]
        public void Update(Modules obj)
        {
            
            objrep.Update(obj);
            
        }

        [HttpGet]
        [Route("api/Module/edit")]
        public Modules Edit(int id)
        {
           return objrep.Edit(id);
             
        }





        [HttpGet]
        [Route("api/Modules/Fill")]
        public List<Modules> FillList()
        {
            return objrep.fill();

        }
        [HttpPost]
        [Route("api/Modules/Removee/{id}")]
        public void Remove(int id)
        {
             objrep.Remove(id);

        }
        [HttpPost]
        [Route("api/Modules/Searsh/{name}")]
        public List<Modules> Search(string name)
        {
            return objrep.Search(name);
        }
    
    }
}
