using Dapper.API.Data.Interfaces.Base;
using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Models.Domain;

namespace Dapper.API.Data.Implementations.CompanyRepository
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly IBaseRepository _baseRepository;

        public CompanyRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            var data = await _baseRepository.QueryAsync<Company>("SELECT * FROM Companies");
            return data;
        }
    }
}
