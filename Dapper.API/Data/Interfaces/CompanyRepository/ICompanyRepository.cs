using Dapper.API.Domain.DTOs.Request.Company;
using Dapper.API.Domain.DTOs.Response.Company;
using Dapper.API.Models.Domain;

namespace Dapper.API.Data.Interfaces.CompanyRepository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<GetAllCompaniesResponseDto>> GetAllCompanies();
        Task<Company> GetCompaniesById(GetCompanyByIdRequestDto request);
    }
}
