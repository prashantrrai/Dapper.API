namespace Dapper.API.Data.Interfaces.Base
{
    public interface IBaseRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sqlquery, object parameters = null);
        //Task<Dapper.SqlMapper.GridReader> QueryMultipleAsync(string sqlquery);
    }
}
