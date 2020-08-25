namespace Questionnare.Services.Services
{

    #region Namespaces

    using Questionnare.Data.IRepository;
    using Questionnare.Models;
    using Questionnare.Services.IServices;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #endregion

    public class CountriesService : ICountriesService
    {
        #region Declarations

        public IRepository<Countries> repository;

        #endregion

        #region Constructor

        public CountriesService(IRepository<Countries> _repository)
        {
            this.repository = _repository;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<Countries>> GetAllCountries()
        {
            try
            {
                return await repository.Query<Countries>(Constants.selectAllCountries);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        #endregion
    }
}
