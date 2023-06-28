using MediatR;
using telneva.idsrv.host.Modules.Tenants.Domain;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Get
{
    public record GetTenantRequest(Tenant tenant) : IRequest<GetTenantResponse>;
}