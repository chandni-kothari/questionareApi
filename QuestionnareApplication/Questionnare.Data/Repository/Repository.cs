namespace Questionnare.Data.Repository
{
    #region Namespaces

    using Dapper;
    using Questionnare.Data.IRepository;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    #endregion

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbConnection _conn;

        public Repository()
        {
            _conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        }

        public async Task<IEnumerable<T>> Query<T>(string query, object parameters = null)
        {
            try
            {
                return await _conn.QueryAsync<T>(query, parameters).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                return new List<T>();
            }
        }

        public async Task<T> QueryFirst<T>(string query, object parameters = null)
        {
            try
            {
                return await _conn.QueryFirstAsync<T>(query, parameters);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
