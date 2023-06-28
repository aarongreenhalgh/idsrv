using FluentValidation;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Create
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.regsiter).NotEmpty();
        }
    }
}
