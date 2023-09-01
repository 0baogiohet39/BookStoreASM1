using Microsoft.AspNetCore.Identity;

namespace BookStoreASM.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string? UCN { get; set; }

        public string? FullName { get; set; }
    }
}
