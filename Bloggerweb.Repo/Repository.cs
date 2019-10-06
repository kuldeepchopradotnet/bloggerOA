using Bloggerweb.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bloggerweb.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbConnection _conn;
        public Repository(IDbConnection conn, char parameterIdentified = '@')
        {
            if (conn == null) throw new ArgumentNullException(nameof(conn), $"The parameter {nameof(conn)} can't be null");
            _conn = conn;
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            // replace with infrastructure  qrySelect now just testing.
            var qrySelect = "Select * from Post";
            IEnumerable<T> result = _conn.Query<T>(qrySelect);
            return result;
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
