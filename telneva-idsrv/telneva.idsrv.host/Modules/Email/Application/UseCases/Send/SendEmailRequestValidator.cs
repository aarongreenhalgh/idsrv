using FluentValidation;

namespace telneva.idsrv.host.Modules.Email.Application.UseCases.Send
{
    public class SendEmailRequestValidator : AbstractValidator<SendEmailRequest>
    {
        public SendEmailRequestValidator()
        {
            RuleFor(x => x.message).NotEmpty();
        }
    }
}
