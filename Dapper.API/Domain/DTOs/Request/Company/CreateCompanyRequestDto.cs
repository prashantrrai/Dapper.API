namespace Dapper.API.Domain.DTOs.Request.Company
{
    public class CreateCompanyRequestDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}
