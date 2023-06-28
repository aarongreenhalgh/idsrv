using MediatR;

namespace telneva.idsrv.host.Modules.Email.Application.UseCases.Send
{
    public class SendEmailRequestHandler : IRequestHandler<SendEmailRequest, SendEmailResponse>
    {
        public Task<SendEmailResponse> Handle(SendEmailRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
