using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(256)]
        public string GivenName { get; set; }
        [MaxLength(256)]
        public string Surname { get; set; }
    }
}
