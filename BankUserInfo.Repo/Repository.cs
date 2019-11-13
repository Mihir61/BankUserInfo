using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }


        public virtual void Add(T item)
        {
            _context.Set<T>().Add(item);
        }
        public virtual void Update(T entityToUpdate)
        {
            _context.Set<T>().Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public virtual void DeleteById(int id)
        {
            T item = GetById(id);
            DeleteByItem(item);
        }
        public virtual void DeleteByItem(T item)
        {
            item = null;
        }
        public virtual void DeleteFromDatabaseById(int id)
        {
            var item = GetById(id);
            DeleteFromDatabaseByItem(item);
        }
        public virtual void DeleteFromDatabaseByItem(T item)
        {
            _context.Set<T>().Remove(item);
        }
    }
}

