using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Accessed
    {
        
        public int ID { get; set; }

        [ForeignKey("GroupName")]
        public int Group_ID  { get; set; }
        public Group GroupName { get; set; }

        [ForeignKey("MoudleName")]
        public int Moudle_ID { get; set; }
        public Modules MoudleName { get; set; }
    }
}
