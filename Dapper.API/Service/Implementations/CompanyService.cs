using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Models.Domain;
using Dapper.API.Service.Interfaces;

namespace Dapper.API.Service.Implementations
{
    public class CompanyService: ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            try
            {
                return await _companyRepository.GetAllCompanies();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
