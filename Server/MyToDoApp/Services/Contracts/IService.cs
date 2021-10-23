using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface IService<T>
    {
        public Task<T> GetById(Guid id);
        public List<T> GetAll();
        public Task<T> Add(T book);
    }
}
