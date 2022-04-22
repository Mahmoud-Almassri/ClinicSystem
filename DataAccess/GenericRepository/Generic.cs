using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using System.Data.Entity;
namespace DataAccess.GenericRepository
{
   public class Generic<T> :IGeneric<T> where T:class
    {
       ContextClinic ocon;
       DbSet<T> Table = null;

       public Generic()
       {
           ocon = new ContextClinic();
           Table = ocon.Set<T>();
       }
        public void Insert(T obj)
        {
         
           
            Table.Add(obj);
        }

        public void Update(T obj)
        {
            Table.Attach(obj);
            ocon.Entry(obj).State = EntityState.Modified;
        }

        public T Get(int id)
        {
            
         return Table.Find(id);
            
        }

        public void GetAll(T obj)
        {
            
            Table.ToList<T>();
        }
        public void Remove(int obj)
        {
            T x = Table.Find(obj);
            Table.Remove(x);
        }

        public void Save()
        {
            ocon.SaveChanges();
        }
       public T Search(string name)
        {
            return Table.Find(name);
        }







        
    }
}
