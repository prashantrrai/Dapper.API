using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Domain.DTOs.Request.Company;
using Dapper.API.Domain.DTOs.Response.Company;
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

        public async Task<IEnumerable<GetAllCompaniesResponseDto>> GetAllCompanies()
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

        public async Task<Company> GetCompaniesById(GetCompanyByIdRequestDto request)
        {
            try
            {
                return await _companyRepository.GetCompaniesById(request);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
