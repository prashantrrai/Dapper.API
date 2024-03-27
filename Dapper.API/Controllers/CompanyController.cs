using System.Data.SqlClient;
using Dapper.API.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IConfiguration config;

        public CompanyController(IConfiguration config)
        {
            this.config = config;
        }


        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAllCompanies ()
        {
            try
            {
                using var connection = new SqlConnection(config.GetConnectionString("DapperConnectionString"));
                var data = await connection.QueryAsync<Company>("SELECT * FROM Companies");

                return Ok(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult> GetCompaniesById(int Id)
        {
            try
            {
                using var connection = new SqlConnection(config.GetConnectionString("DapperConnectionString"));
                //var data = await connection.QueryFirstAsync<Company>($"SELECT * FROM Companies WHERE Id = {Id}");
                var data = await connection.QueryFirstOrDefaultAsync<Company>("SELECT * FROM Companies WHERE Id = @Id", new { Id = Id });

                if (data == null)
                {
                    return NotFound();
                }
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateCompanies(Company company)
        //{
        //    try
        //    {
        //        using var connection = new SqlConnection(config.GetConnectionString("DapperConnectionString"));
        //        string sql = @"INSERT INTO Companies (Name, Address, Country) 
        //               VALUES (@Name, @Address, @Country);
        //               SELECT CAST(SCOPE_IDENTITY() AS INT)";

        //        int newCompanyId = await connection.QuerySingleAsync<int>(sql, company);

        //        Company createdCompany = await connection.QueryFirstOrDefaultAsync<Company>("SELECT * FROM Companies WHERE Id = @Id", new { Id = newCompanyId });

        //        return CreatedAtAction(nameof(GetCompaniesById), new { Id = newCompanyId }, createdCompany);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
