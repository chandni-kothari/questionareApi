using Questionnare.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Questionnare.Services.IServices
{
    public interface ICountriesService
    {
        Task<IEnumerable<Countries>> GetAllCountries();
    }
}
