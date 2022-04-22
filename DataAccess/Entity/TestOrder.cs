using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entity
{
    public class TestOrder
    {
        public int ID { get; set; }
        public string TestName { get; set; }
        public string TestDetails { get; set; }
        public string TestReporte { get; set; }
        public string CreatedOn { get; set; }
        [ForeignKey("Visit_TestOrder")]
        public int Visit_ID { get; set; }
        public Visit Visit_TestOrder { get; set; }
    }
}
