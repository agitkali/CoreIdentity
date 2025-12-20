using Microsoft.AspNetCore.Identity;

namespace ASPNETCoreIdentityFrameWork.Data
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
