using MediatR;
using telneva.idsrv.host.Modules.SMS.Domain;

namespace telneva.idsrv.host.Modules.SMS.Application.UseCases.Send
{
    public record SendSMSRequest(SMSMessage message) : IRequest<SendSMSResponse>;
}