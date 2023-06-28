using MediatR;
using telneva.idsrv.host.Modules.Email.Domain;

namespace telneva.idsrv.host.Modules.Email.Application.UseCases.Send
{
    public record SendEmailRequest(EmailMessage message) : IRequest<SendEmailResponse>;
}