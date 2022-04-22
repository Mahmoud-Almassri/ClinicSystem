using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Entity;
namespace ClinicSystem.Areas.Admin.Models
{
    public class ModuleVM
    {
        public List<Modules> ModuleList { get; set; }
    }
}