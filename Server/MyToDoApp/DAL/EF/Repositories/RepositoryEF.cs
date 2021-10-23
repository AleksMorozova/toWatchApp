using Microsoft.EntityFrameworkCore;
using MyToDoApp.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class RepositoryEF<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<T> dbSet;
        public RepositoryEF(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public async Task<T> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
        public async Task<T> AddAsync(T entity)
        {
            var e = await dbSet.AddAsync(entity);
            _context.SaveChanges();
            return e.Entity;
        }
        public T Update(T entity)
        {
            dbSet.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
