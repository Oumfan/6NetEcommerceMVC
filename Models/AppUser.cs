using Microsoft.AspNetCore.Identity;

namespace lastEcommerceMVC.Models
{
    public class AppUser : IdentityUser
    {
        public string? Occupation { get; set; }
        public AppUser()
        {
            Occupation = "";
        }
    }
}
