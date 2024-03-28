namespace Dapper.API.Domain.DTOs.Request.Company
{
    public class CreateCompanyRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}
