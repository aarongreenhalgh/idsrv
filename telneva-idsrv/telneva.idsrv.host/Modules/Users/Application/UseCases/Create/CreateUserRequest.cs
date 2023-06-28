using MediatR;
using telneva.idsrv.host.Modules.Users.Domain;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Create
{
    public record CreateUserRequest(Register regsiter) : IRequest<CreateUserResponse>;
}