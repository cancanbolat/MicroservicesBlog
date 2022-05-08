using Blog.Application.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _dbConnection;

        public GenericRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnection = new SqlConnection(configuration["SQLSERVER"]);
        }

        private IEnumerable<string> GetEntityColumns()
        {
            return typeof(T).GetProperties()
                .Where(x => 
                x.Name != "Id" &&
                !x.PropertyType.GetTypeInfo().IsGenericType)
                .Select(x => x.Name);
        }

        public async Task<int> CreateAsync(T entity)
        {
            var columns = GetEntityColumns();
            var stringOfColumns = String.Join(", ", columns);
            var stringOfParamaters = String.Join(", ", columns.Select(x => "@" + x));

            var query = $"INSERT INTO {typeof(T).Name}s ({stringOfColumns}) VALUES({stringOfParamaters})";

            var executeStatus = await _dbConnection.ExecuteAsync(query, entity);

            return executeStatus;
        }

        public void DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var query = $"SELECT * FROM {typeof(T).Name}s";
            var posts = await _dbConnection.QueryAsync<T>(query);

            return posts.ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var query = $"SELECT * FROM {typeof(T).Name}s WHERE Id = {id}";
            var post = await _dbConnection.QueryAsync<T>(query);

            return post.FirstOrDefault();
        }

        public Task<int> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetBySlugAsync(string slug)
        {
            //TODO: Slug olarak kaydetmek lazım
            var query = $"SELECT * FROM {typeof(T).Name}s WHERE Title = {slug}";
            var post = await _dbConnection.QueryAsync<T>(query);

            return post.FirstOrDefault();
        }
    }
}
