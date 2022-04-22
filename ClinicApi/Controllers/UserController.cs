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
    public class UserController : ApiController
    {
        IUserReposotory objrep = new UserReposotory();

        [HttpGet]
        [Route("api/User/FillGroup")]

        public List<Group> FillGroup()
        {

            return objrep.FillGroup();

        }

        [HttpGet]
        [Route("api/User/Fill")]

        public List<Speciality> FillSpeciality()
        {

            return objrep.FillSpeciality();

        }
       [HttpPost]
       [Route("api/User/insertuse")]
        public void Insert(Users user)
        {

            objrep.Insert(user);


        }
       
        [HttpPost]
        [Route("api/User/updateuser")]
        public void Update(Users us)
        {
            objrep.Update(us);

        }
        [HttpGet]
        [Route("api/User/FillUserList")]
        public List<Users> FillUserList()
        {
            return objrep.FillUser();
        }
        [HttpPost]
        [Route("api/User/Removee/{id}")]
        public void Remove(int id)
        {
            objrep.Remove(id);
        }
        [HttpGet]
        [Route("api/User/Edit")]
        public Users Edit(int id)
        {
            return objrep.Edit(id);
        }
    }
}
