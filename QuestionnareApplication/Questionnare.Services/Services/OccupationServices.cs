namespace Questionnare.Services.Services
{
    #region Namespaces

    using System;
    using Questionnare.Data.IRepository;
    using Questionnare.Models;
    using Questionnare.Services.IServices;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #endregion

    public class OccupationServices : IOccupationServices
    {
        #region Declarations

        public IRepository<Countries> repository;

        #endregion

        #region Constructor

        public OccupationServices(IRepository<Countries> _repository)
        {
            this.repository = _repository;
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<Occupation>> GetAllOccupations()
        {
            try
            {
                return await repository.Query<Occupation>(Constants.selectAllOccupations);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
