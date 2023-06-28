using FluentValidation;
using MediatR;
using System.Text.Json;

namespace telneva.idsrv.host.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = _validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Select(x => x.ErrorMessage)
                .Where(f => f != null)
                .ToList();

            var result = JsonSerializer.Serialize(failures);

            if (failures.Count != 0)
            {
                throw new ValidationException(result);
            }

            return next();
        }
    }
}