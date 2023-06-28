using Microsoft.AspNetCore.Identity;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Create
{
    public class CreateUserResponse
    {
        public CreateUserResponse(IdentityUser user, IdentityResult result)
        {
            Errors = result.Errors;
            IsSuccess = !result.Errors.Any();
            UserId= user.Id;
        }

        public string UserId { get; set; }

        public bool IsSuccess { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    
        public IEnumerable<IdentityError> Errors { get; set; }
    }
}