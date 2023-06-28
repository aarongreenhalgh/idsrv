using FluentValidation;

namespace telneva.idsrv.host.Modules.SMS.Application.UseCases.Send
{
    public class SendSMSRequestValidator : AbstractValidator<SendSMSRequest>
    {
        public SendSMSRequestValidator()
        {
            RuleFor(x => x.message).NotEmpty();
        }
    }
}
