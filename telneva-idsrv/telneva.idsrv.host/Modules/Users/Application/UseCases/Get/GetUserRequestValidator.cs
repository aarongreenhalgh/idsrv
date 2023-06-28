using FluentValidation;
using telneva.idsrv.host.Modules.Users.Application.UseCases.Get;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Get
{
    public class GetUserRequestValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserRequestValidator()
        {
            RuleFor(x => x.id).NotNull();
        }
    }
}
