using FluentValidation;
using ObjectValidator.Domain.ConfirmedViolationCreated;

namespace ObjectValidator.FluentValidator.MetadataValidator
{
    public class ConfirmedViolationMetadataValidator : AbstractValidator<ConfirmedViolationCreated>
    {
        public ConfirmedViolationMetadataValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.PotentialViolations)
                .Must(x => x.Count == 2).WithMessage("Less than 2 PotentialViolations are not allowed");
            RuleForEach(x => x.PotentialViolations).SetValidator(new PotentialViolationMetadataValidator());
        }
    }
}
