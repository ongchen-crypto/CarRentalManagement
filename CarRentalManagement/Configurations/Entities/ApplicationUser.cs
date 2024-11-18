using CarRentalManagement.Data;

namespace CarRentalManagement.Configurations.Entities
{
    internal class ApplicationUser : IEnumerable<CarRentalManagementUser>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string PasswordHash { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}