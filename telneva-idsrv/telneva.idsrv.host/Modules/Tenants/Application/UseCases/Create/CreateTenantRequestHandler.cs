using MediatR;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.Create
{
    public class CreateTenantRequestHandler : IRequestHandler<CreateTenantRequest, CreateTenantResponse>
    {
        public Task<CreateTenantResponse> Handle(CreateTenantRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
