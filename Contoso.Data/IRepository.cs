using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T> where T: class//generic constraints,只能用class replace T， not struct//restricting能用model
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> where);//pass linq expression
        void SaveChanges();
    }
}
