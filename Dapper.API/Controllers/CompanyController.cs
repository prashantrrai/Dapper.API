using System.Data.SqlClient;
using Dapper.API.Models.Domain;
using Dapper.API.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.API.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllCompanies ()
        {
            try
            {
                var data = await _companyService.GetAllCompanies();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //[HttpGet("{Id}")]
        //public async Task<ActionResult> GetCompaniesById(int Id)
        //{
        //    try
        //    {
        //        using var connection = new SqlConnection(config.GetConnectionString("DapperConnectionString"));
        //        //var data = await connection.QueryFirstAsync<Company>($"SELECT * FROM Companies WHERE Id = {Id}");
        //        var data = await connection.QueryFirstOrDefaultAsync<Company>("SELECT * FROM Companies WHERE Id = @Id", new { Id = Id });

        //        if (data == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(data);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

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
