using Questionnare.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Questionnare.Services.IServices
{
    public interface IOccupationServices
    {
        Task<IEnumerable<Occupation>> GetAllOccupations();
    }
}
