using System.Data.SqlClient;
using Dapper.API.Data.Interfaces.Base;

namespace Dapper.API.Data.Implementations.Base
{
    public class BaseRepository: IBaseRepository
    {
        private readonly IConfiguration _config;

        public BaseRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DapperConnectionString")))
            {
                return await connection.QueryAsync<T>(sql);
            }
        }
    }
}
