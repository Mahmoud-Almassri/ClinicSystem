using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinicSystem.Areas.Admin.Models;
using DataAccess.Entity;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ClinicSystem.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /Admin/User/
        
        public ActionResult NewUsers()
        {
            return View("NewUsers");
        }
        public ActionResult New_Users(int id)
        {
            ViewBag.x = id;
            return View("NewUsers");
        }
        public async Task<ActionResult> UsersList()
        {
            UseresVM vm=new UseresVM();
            List<Users> userlist = new List<Users>();
            string apiURL = "http://localhost/ClinicApi/api/User/FillUserList";                        
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage ResponseMessage = await client.GetAsync(apiURL);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var responseDate = ResponseMessage.Content.ReadAsStringAsync().Result;
                userlist = JsonConvert.DeserializeObject<List<Users>>(responseDate);
            }
            vm.UserLi = userlist;


            return View("UsersList",vm);
        }
	}
}