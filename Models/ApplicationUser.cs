// to extend the identityUser registration details
using Microsoft.AspNetCore.Identity;

namespace SalesCRMApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}