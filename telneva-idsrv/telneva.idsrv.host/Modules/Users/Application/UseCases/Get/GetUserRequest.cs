using MediatR;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Get
{
    public record GetUserRequest(Guid id) : IRequest<GetUserResponse>;
}