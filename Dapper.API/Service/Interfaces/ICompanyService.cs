using Dapper.API.Models.Domain;

namespace Dapper.API.Service.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAllCompanies();
    }
}
