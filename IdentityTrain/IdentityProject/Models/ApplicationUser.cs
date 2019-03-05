using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Year { get; set; }
        public ApplicationUser()
        {
        }
    }
}