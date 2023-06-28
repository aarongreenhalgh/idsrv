using MediatR;
using telneva.idsrv.host.Modules.Users.Application.UseCases.Get;

namespace telneva.idsrv.host.Modules.Users.Application.UseCases.Get
{
    public class GetUserRequestHandler : IRequestHandler<GetUserRequest, GetUserResponse>
    {
        public Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}