using MediatR;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.ListUsers
{
    public record ListUsersRequest() : IRequest<ListUsersResponse>;
}