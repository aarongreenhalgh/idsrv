using FluentValidation;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Get
{
    public class GetTenantRequestValidator : AbstractValidator<GetTenantRequest>
    {
        public GetTenantRequestValidator()
        {
            RuleFor(x => x.tenant).NotNull();
        }
    }
}
