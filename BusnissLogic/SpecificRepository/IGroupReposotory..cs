using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;
using DataAccess.GenericRepository;


namespace BusnissLogic.SpecificRepository
{
   public interface IGroupReposotory 
    {
        void Insert(Group Grp);
        void Update(Group Grp);

        List<Group> GroupList();
        Group Edit(int id);
        void Remove(int id);

    }
}
