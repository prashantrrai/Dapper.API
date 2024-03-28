namespace Dapper.API.Models.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        //public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
