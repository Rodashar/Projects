using QuadrusMotorCompany.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Generics
{
    public class GenericRepository<T> where T : class 
    {
        protected readonly EntityFrameworkDataContext _dataContext;

        public GenericRepository()
        {
            this._dataContext = new EntityFrameworkDataContext();
        }

        public IEnumerable<T> GetAll()
        {
            return this._dataContext.Set<T>().ToList();
        }

        public T FindBy(Guid id)
        {
            return this._dataContext.Set<T>().Find(id);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return this._dataContext.Set<T>().Where(predicate).ToList();
        }

        public T FindFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return this._dataContext.Set<T>().FirstOrDefault(predicate);
        }

        public T Create(T entity)
        {
            this._dataContext.Set<T>().Add(entity);
            this._dataContext.SaveChanges();
            return entity;
        }

        public T Update(T entity, Guid id)
        {
            if (entity == null)
                throw new ArgumentNullException();

            T existing = this._dataContext.Set<T>().Find(id);

            if (existing == null)
                throw new InvalidOperationException();

            this._dataContext.Entry(existing).CurrentValues.SetValues(entity);
            this._dataContext.SaveChanges();

            return existing;
        }

        public void Delete(Guid id)
        {
            T entityToDelete = FindBy(id);
            Delete(entityToDelete);
        }

        public void Delete(T entity)
        {
            if (this._dataContext.Entry(entity).State == EntityState.Detached)
            {
                this._dataContext.Set<T>().Attach(entity);
            }

            this._dataContext.Set<T>().Remove(entity);
            this._dataContext.SaveChanges();
        }
    }
}
