using Dapper;
using Microsoft.Data.SqlClient;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_Dapper
{
    public class RepositoryDapper<T> : IRepository<T> where T : class
    {
        public virtual string InsertQuery
        {
            get;
        }
        public virtual string ReadQuery
        {
            get;
        }

        public async Task<T> AddAsync(T entity)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
            {
                connection.Open();
                await connection.ExecuteAsync(InsertQuery, entity);
                return entity;
            }
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
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
