using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository
{
   public interface IGeneric<T>
    {
       void Insert(T obj);
       void Update(T obj);
       T Get(int id);
       void GetAll(T obj);

       void Remove(int obj);
       void Save();
       T Search(string name);
    }
}
