using Dapper.API.Models.Domain;

namespace Dapper.API.Data.Interfaces.CompanyRepository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAllCompanies();
    }
}
