namespace Dapper.API.Data.Interfaces.Base
{
    public interface IBaseRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql);
    }
}
