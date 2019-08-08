using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Clientes.Infra.Repositories;
using Projeto.Infra.Repositories.Context;
using System.Data.Entity;


namespace Projeto.Infra.Repositories.Persistence
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public void Delete(T obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<T> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

        public T FindById(int id)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        public void Insert(T obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(T obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
