using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccess.Entity
{
    public class Diagonostics
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string diagonostics { get; set; }

        [ForeignKey("Visit_Diagonostics")]
        public int Visit_ID { get; set; }
        public Visit Visit_Diagonostics { get; set; }

    }
}
