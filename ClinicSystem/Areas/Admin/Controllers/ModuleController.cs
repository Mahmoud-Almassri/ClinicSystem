using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAccess.Entity;
using System.Net.Http;
using Newtonsoft.Json;
using ClinicSystem.Areas.Admin.Models;
namespace ClinicSystem.Areas.Admin.Controllers
{
    public class ModuleController : Controller
    {
        //
        // GET: /Admin/Module/
        [HttpGet]
        public ActionResult NewModules()
        {
            ViewBag.x = 0;
            return View();
        }
       
        public ActionResult New_Modules(int id)
        {
            ViewBag.x = id;
            return View("NewModules");
        }

        public async Task<ActionResult> ModulesList()
        {
            ModuleVM vm = new ModuleVM();
            List<Modules> modulelist = new List<Modules>();
            string apiURL = "http://localhost/ClinicApi/api/Modules/Fill";                            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage ResponseMessage = await client.GetAsync(apiURL);

            if (ResponseMessage.IsSuccessStatusCode)
            {
                var responsedata = ResponseMessage.Content.ReadAsStringAsync().Result;
                modulelist = JsonConvert.DeserializeObject<List<Modules>>(responsedata);
                
            }
           
            vm.ModuleList = modulelist;
            return View("ModulesList",vm);
        }
        //public async Task<ActionResult> ModulesList()
        //{
        //    string name=@ViewBag.name;
        //    ModuleVM vm = new ModuleVM();
        //    List<Modules> modulelist = new List<Modules>();
        //    string apiURL = "http://localhost/ClinicApi/api/Modules/Search";
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(apiURL);
        //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage ResponseMessage = await client.GetAsync(apiURL);

        //    if (ResponseMessage.IsSuccessStatusCode)
        //    {
        //        var responsedata = ResponseMessage.Content.ReadAsStringAsync().Result;
        //        modulelist = JsonConvert.DeserializeObject<List<Modules>>(responsedata);

        //    }

        //    vm.ModuleList = modulelist;
        //    return View("ModulesList", vm);
        //}
	}
}