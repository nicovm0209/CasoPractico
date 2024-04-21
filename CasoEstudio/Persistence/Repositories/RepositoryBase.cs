using Application.Contexts;
using Application.Repositories;
using Domain;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : Entity
    {
        protected readonly AplicationDbContext _context;
        protected readonly DbSet<T> _entities;

        public RepositoryBase(AplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities;
            query = query.Where(predicate);

            return query.FirstOrDefault();
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }


        public void Save()
        {
            _context.Save();
        }
    }
}
