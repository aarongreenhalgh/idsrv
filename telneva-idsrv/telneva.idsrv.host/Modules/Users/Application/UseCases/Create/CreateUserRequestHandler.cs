using MediatR;
using Microsoft.AspNetCore.Identity;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Create
{
    public class CreateUserRequestHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public CreateUserRequestHandler(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            IdentityUser user = new()
            {
                Email = request.regsiter.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.regsiter.Email,
                NormalizedEmail = request.regsiter.Email,
                NormalizedUserName = request.regsiter.Email
            };

            if (!await _roleManager.RoleExistsAsync("admin"))
                await _roleManager.CreateAsync(new IdentityRole("admin"));
            if (!await _roleManager.RoleExistsAsync("user"))
                await _roleManager.CreateAsync(new IdentityRole("user"));

            if (await _roleManager.RoleExistsAsync("admin"))
            {
                await _userManager.AddToRoleAsync(user, "admin");
            }
            if (await _roleManager.RoleExistsAsync("admin"))
            {
                await _userManager.AddToRoleAsync(user, "user");
            }
            
            var result = await _userManager.CreateAsync(user, request.regsiter.Password);

            return new CreateUserResponse(user, result);
        }
    }
}
