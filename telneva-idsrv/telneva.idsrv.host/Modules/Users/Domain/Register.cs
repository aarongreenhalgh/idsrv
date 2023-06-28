using System.ComponentModel.DataAnnotations;

namespace telneva.idsrv.host.Modules.Users.Domain
{
    public class Register
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        [Required]
        public string UserRole { get; set; } = default!;
    }
}