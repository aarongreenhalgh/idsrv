using MediatR;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.ListUsers
{
    public class ListUsersRequestHandler : IRequestHandler<ListUsersRequest, ListUsersResponse>
    {
        public Task<ListUsersResponse> Handle(ListUsersRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}