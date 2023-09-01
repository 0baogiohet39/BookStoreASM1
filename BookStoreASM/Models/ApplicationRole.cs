using Microsoft.AspNetCore.Identity;

namespace BookStoreASM.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? Descriptions;
    }
}
