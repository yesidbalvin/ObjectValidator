using FluentValidation;
using ObjectValidator.Domain.ConfirmedViolationCreated;

namespace ObjectValidator.FluentValidator.Validator
{
    public class ConfirmedViolationCreatedValidator : AbstractValidator<ConfirmedViolationCreated>
    {
        /*This example was made using FluentValidation
         */
        public ConfirmedViolationCreatedValidator()
        {
            //RuleFor(x => x.Id).NotEqual(Guid.Empty);
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.PotentialViolations)
                .Must(x => x.Count == 2).WithMessage("Less than 2 PotentialViolations are not allowed");
            RuleForEach(x => x.PotentialViolations).SetValidator(new PotentialViolationCreatedValidator());
        }
    }
}
