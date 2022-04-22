using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
        public List<Accessed> Accessed_Group { get; set; }
        public List<Users> user { get; set; }
    }
}
