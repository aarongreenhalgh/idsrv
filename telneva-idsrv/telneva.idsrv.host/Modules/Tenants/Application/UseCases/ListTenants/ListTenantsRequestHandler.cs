using MediatR;
using telneva.idsrv.host.Modules.Users.Application.UseCases.ListUsers;

namespace telneva.idsrv.host.Modules.Tenants.Application.UseCases.ListTenants
{
    public class ListTenantsRequestHandler : IRequestHandler<ListUsersRequest, ListUsersResponse>
    {
        public Task<ListUsersResponse> Handle(ListUsersRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}