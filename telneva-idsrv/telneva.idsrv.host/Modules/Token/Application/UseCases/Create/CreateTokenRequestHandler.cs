using MediatR;

namespace telneva.idsrv.host.Modules.Token.Application.UseCases.Create
{
    public class CreateTokenRequestHandler : IRequestHandler<CreateTokenRequest, CreateTokenResponse>
    {
        public Task<CreateTokenResponse> Handle(CreateTokenRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
