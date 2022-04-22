using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using DataAccess.GenericRepository;
using DataAccess.Context;

namespace BusnissLogic.SpecificRepository
{
   public class GroupReposotory :IGroupReposotory
    {
        public void Insert(Group Grp)
        {
            Generic<Group> generic = new Generic<Group>();
            
            generic.Insert(Grp);
            generic.Save();
        }
        public void Update(Group grp)
        {

            Generic<Group> generic = new Generic<Group>();


            generic.Update(grp);


            generic.Save();
        }


        public List<Group> GroupList()
        {
            List<Group> li = new List<Group>();
            ContextClinic con=new ContextClinic();
            var data = from x in con.Gro
                       select x;
            foreach (var item in data)
            {
                Group grp = new Group();
                grp.ID = item.ID;
                grp.Name = item.Name;
                grp.Status = item.Status;
                grp.ShortName = item.ShortName;
                li.Add(grp);
            }
            return li;
        }


        public Group Edit(int id)
        {
            IGeneric<Group> grp = new Generic<Group>();
            Group s= grp.Get(id);
            grp.Save();
            return s;
        }


        public void Remove(int id)
        {
            IGeneric<Group> grp = new Generic<Group>();
            grp.Remove(id);
            grp.Save();
        }
    }
}
