using System.Collections.Generic;
using System.Threading.Tasks;

namespace Questionnare.Data.IRepository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Query<T>(string query, object parameters = null);
        Task<T> QueryFirst<T>(string query, object parameters = null);
    }
}
