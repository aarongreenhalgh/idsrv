using MediatR;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.ListTenants
{
    public record ListTenantsRequest() : IRequest<ListTenantsResponse>;
}