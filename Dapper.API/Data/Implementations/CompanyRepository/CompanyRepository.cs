using Dapper.API.Data.Interfaces.Base;
using Dapper.API.Data.Interfaces.CompanyRepository;
using Dapper.API.Domain.DTOs.Request.Company;
using Dapper.API.Domain.DTOs.Response.Company;
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

        public async Task<IEnumerable<GetAllCompaniesResponseDto>> GetAllCompanies()
        {
            var data = await _baseRepository.QueryAsync<GetAllCompaniesResponseDto>("SELECT * FROM Companies");
            return data;
        }

        public async Task<Company> GetCompaniesById(GetCompanyByIdRequestDto request)
        {
            var data = await _baseRepository.QueryAsync<Company>("SELECT * FROM Companies WHERE Id = @CompanyId", new { CompanyId = request.CompanyId });
            return data.FirstOrDefault();
        }
    }
}
