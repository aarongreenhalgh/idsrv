using MediatR;

namespace telneva.idsrv.host.Modules.SMS.Application.UseCases.Send
{
    public class SendSMSRequestHandler : IRequestHandler<SendSMSRequest, SendSMSResponse>
    {
        public Task<SendSMSResponse> Handle(SendSMSRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
