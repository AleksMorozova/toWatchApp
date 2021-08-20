using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetById(Guid id);
        List<T> GetAll();
        Task<T> AddAsync(T entity);
        T Update(T entity);
    }
}
