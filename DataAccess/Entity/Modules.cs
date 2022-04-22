using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
   public class Modules
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Order { get; set; }
        public string Path { get; set; }
        public int SubModule { get; set; }
        public List<Accessed> Accessed_Modules { get; set; }

    }
}
