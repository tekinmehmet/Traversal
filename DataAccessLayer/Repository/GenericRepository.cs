using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        
        public void Delete(T t)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(t);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);

        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}


//using (TContex context = new TContex())
//{
//    context.Configuration.AutoDetectChangesEnabled = false;
//    context.Configuration.LazyLoadingEnabled = false;
//    context.Configuration.ProxyCreationEnabled = false;
//    return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
//}


//using (TContex context = new TContex())
//{
//    context.Configuration.AutoDetectChangesEnabled = false;
//    context.Configuration.LazyLoadingEnabled = false;
//    context.Configuration.ProxyCreationEnabled = false;
//    var addedEntity = context.Entry(entity);
//    addedEntity.State = EntityState.Added;
//    context.SaveChanges();
//}