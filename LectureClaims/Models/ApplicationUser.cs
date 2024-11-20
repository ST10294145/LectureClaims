using Microsoft.AspNetCore.Identity;

namespace LectureClaims.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
