using MediatR;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Get
{
    public class GetTenantRequestHandler : IRequestHandler<GetTenantRequest, GetTenantResponse>
    {
        public Task<GetTenantResponse> Handle(GetTenantRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}