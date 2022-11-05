namespace BlazorApp1.Data.Models
{
    public class Tenant : TenantDto
    {
        public int Id { get; set; }
        
    }

    public class TenantDto
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime DateOfBirth { get; set; } = new DateTime();
    }
}
