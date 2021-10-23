using Dapper;
using Microsoft.Extensions.DependencyInjection;
using MyToDoApp.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.Dapper.Repositories
{
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {
        private readonly IServiceProvider _provider;

        public RepositoryDapper(IServiceProvider provider)
        {
            _provider = provider;
        }
        public virtual string InsertQuery
        {
            get;
        }
        public virtual string ReadSingleQuery
        {
            get;
        }
        public virtual string ReadQuery
        {
            get;
        }

        public async Task<T> AddAsync(T entity)
        {
            using (var connection = _provider.GetRequiredService<IDbConnection>())
            {
                connection.Open();
                await connection.ExecuteAsync(InsertQuery, entity);
                return entity;
            }
        }

        public async Task<T> GetById(Guid id)
        {
            using (var connection = _provider.GetRequiredService<IDbConnection>())
            {
                connection.Open();
                var result = await connection.QuerySingleAsync<T>(ReadSingleQuery, id);
                return result;
            }
        }

        public List<T> GetAll()
        {
            using (var connection = _provider.GetRequiredService<IDbConnection>())
            {
                connection.Open();
                var result = connection.Query<T>(ReadQuery);
                return result.ToList();
            }
        }
        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
