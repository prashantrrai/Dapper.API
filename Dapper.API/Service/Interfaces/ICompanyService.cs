using Dapper.API.Domain.DTOs.Request.Company;
using Dapper.API.Domain.DTOs.Response.Company;
using Dapper.API.Models.Domain;

namespace Dapper.API.Service.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<GetAllCompaniesResponseDto>> GetAllCompanies();
        Task<Company> GetCompaniesById (GetCompanyByIdRequestDto request);
    }
}
