using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Entity;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ClinicSystem.Areas.Admin.Models;
namespace ClinicSystem.Areas.Admin.Controllers
{
    public class GroupController : Controller
    {
        //
        // GET: /Admin/Group/
       
        public ActionResult NewGroup()
        {
            ViewBag.x = 0;
            return View("NewGroup");
        }
        
        public ActionResult New_Group(int id)
        {
            ViewBag.x=id;
            return View("NewGroup");
        }
        
        public async Task<ActionResult> GroupList()
        {
            GroupVM vm = new GroupVM();
            List<Group> GroupList = new List<Group>();
            string apiURL = "http://localhost/ClinicApi/api/Group/Fill";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiURL);

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage ResponseMessage = await client.GetAsync(apiURL);
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var ResponseDate = ResponseMessage.Content.ReadAsStringAsync().Result;
                GroupList = JsonConvert.DeserializeObject<List<Group>>(ResponseDate);
            }

            vm.GroupListVM = GroupList;
            return View("GroupList", vm);


        }
	}
}