using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Sysptom
    {
        
        public int ID { get; set; }
        public string SysptomTitle { get; set; }
        public string sysptom { get; set; }
        [ForeignKey("Visit_Sysptom")]
        public int Visit_ID { get; set; }
        public Visit Visit_Sysptom { get; set; }
    }
}
