using FluentValidation;

namespace telneva.idsrv.host.Modules.Token.Application.UseCases.Create
{
    public class CreateTokenRequestValidator : AbstractValidator<CreateTokenRequest>
    {
        public CreateTokenRequestValidator()
        {
            RuleFor(x => x.login).NotEmpty();
        }
    }
}
