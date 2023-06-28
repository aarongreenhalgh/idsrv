using MediatR;
using telneva.idsrv.host.Modules.Token.Domain;

namespace telneva.idsrv.host.Modules.Token.Application.UseCases.Create
{
    public record CreateTokenRequest(Login login) : IRequest<CreateTokenResponse>;
}