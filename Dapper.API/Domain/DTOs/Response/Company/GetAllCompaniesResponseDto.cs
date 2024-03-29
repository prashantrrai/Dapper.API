namespace Dapper.API.Domain.DTOs.Response.Company
{
    public class GetAllCompaniesResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
