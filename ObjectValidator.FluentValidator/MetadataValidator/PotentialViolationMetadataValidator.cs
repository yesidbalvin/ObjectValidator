using FluentValidation;
using ObjectValidator.Domain.ConfirmedViolationCreated;

namespace ObjectValidator.FluentValidator.MetadataValidator
{
    public class PotentialViolationMetadataValidator:AbstractValidator<PotentialViolationCreated>
    {
        public PotentialViolationMetadataValidator()
        {
            RuleFor(x=>x.LicensePlateImagePath).NotEmpty();
            RuleFor(x=>x.FrontFacingImagePath).NotEmpty();
            RuleFor(x=>x.LicenseOverviewImagePath).NotEmpty();
            RuleFor(x=>x.CaptureDateTimestamp).NotEmpty();
            RuleFor(x=>x.OffsetValue).NotEmpty();
            RuleFor(x=>x.BusId).NotEmpty();
            RuleFor(x=>x.LicensePlateNumber).NotEmpty();
            RuleFor(x=>x.Confidence).NotEmpty();
            RuleFor(x=>x.Direction).NotEmpty();
            RuleFor(x=>x.PlateHeight).NotEmpty();
            RuleFor(x=>x.PlateWidth).NotEmpty();
            RuleFor(x=>x.PlateX).NotEmpty();
            RuleFor(x=>x.PlateY).NotEmpty();
            RuleFor(x=>x.CameraId).NotEmpty();
            RuleFor(x=>x.EvidenceEndTime).NotEmpty();
            RuleFor(x=>x.GpsLatitude).NotEmpty();
            RuleFor(x=>x.GpsLongitude).NotEmpty();
            RuleFor(x=>x.LastSynchronizationTime).NotEmpty();
            RuleFor(x=>x.CameraId).NotEmpty();
            RuleFor(x=>x.GeofenceAddress).NotEmpty();
            RuleFor(x=>x.GeofenceCode).NotEmpty();
            RuleFor(x=>x.EvidenceStartTime).NotEmpty();
            RuleFor(x=>x.CaptureDateTimestamp).NotEmpty();
        }
    }
}
