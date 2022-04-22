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
    public class GroupController : ApiController
    {
        IGroupReposotory GrpRep = new GroupReposotory();
         
         [Route("api/Group/InsertGro")]
        public void Insert(Group grp)
        {
            GrpRep.Insert(grp);
        }


         [HttpPost]
         [Route("api/Group/Update")]
         public void Update(Group Grp)
         {
             GrpRep.Update(Grp);
            

         }
        [HttpGet]
        [Route("api/Group/Fill")]
        public List<Group> List_Group()
         {
           return  GrpRep.GroupList();
         }
        [HttpGet]
        [Route("api/Group/Edit")]
        public Group Edit(int id)
        {
          return GrpRep.Edit(id);
        }

        [HttpPost]
        [Route("api/Group/Removee/{id}")]
        public void Remove(int id)
        {
            GrpRep.Remove(id);
            
        }
    }
}
