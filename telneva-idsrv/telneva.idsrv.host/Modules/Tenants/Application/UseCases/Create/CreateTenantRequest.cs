using MediatR;
using telneva.idsrv.host.Modules.Tenants.Domain;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Create
{
    public record CreateTenantRequest(Tenant tenant) : IRequest<CreateTenantResponse>;
}