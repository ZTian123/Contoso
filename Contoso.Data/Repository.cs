using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class//common operations, also may need specific operations
    {
        //initialize dbset and dbcontext
        protected readonly IDbSet<T> dbSet;
        protected ContosoDbContext _context;
        public Repository(ContosoDbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();//or default防止exception
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList();//AsNoTracking is used to imporve the performance when blindly get data, EF will tracking by default
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);//find is inside entity framework
        }

        public IQueryable<T> GetQueryable()
        {
            return dbSet.AsQueryable<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;//added是default
        }
    }
}
