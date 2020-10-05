using FluentValidation;
using ObjectValidator.Domain.ConfirmedViolationCreated;
using System;

namespace ObjectValidator.FluentValidator.Validator
{
    public class PotentialViolationCreatedValidator : AbstractValidator<PotentialViolationCreated>
    {
        public PotentialViolationCreatedValidator()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
            RuleFor(x => x.GeofenceCode).NotEmpty();
            RuleFor(x => x.BusId).NotEmpty();
            RuleFor(x => x.CaptureDateTimestamp).NotEqual(0);
            RuleFor(x => x.LastSynchronizationTime).NotEqual(0);
        }
    }
}
