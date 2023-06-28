using FluentValidation;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Create
{
    public class CreateTenantRequestValidator : AbstractValidator<CreateTenantRequest>
    {
        public CreateTenantRequestValidator()
        {
            RuleFor(x => x.tenant).NotEmpty();
        }
    }
}
