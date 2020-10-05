using System;

namespace ObjectValidator.Domain.ConfirmedViolationCreated
{
  public class PotentialViolationCreated
  {
    public Guid Id { get; set; }
    public string LicensePlateNumber { get; set; }
    public string LicensePlateState { get; set; }
    public string LicensePlateImagePath { get; set; }
    public string LicenseOverviewImagePath { get; set; }
    public string FrontFacingImagePath { get; set; }
    public long CaptureDateTimestamp { get; set; }
    public long EvidenceStartTime { get; set; }
    public long EvidenceEndTime { get; set; }
    public double GpsLatitude { get; set; }
    public double GpsLongitude { get; set; }
    public string BusId { get; set; }
    public int CameraId { get; set; }
    public string GeofenceCode { get; set; }
    public string GeofenceAddress { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.UtcNow;
    public long LastSynchronizationTime { get; set; }
    public Guid? ConfirmedViolationId { get; set; }
    public string VideoUrl { get; set; }
    public string JoinedImageUrl { get; set; }
    public double Confidence { get; set; }
    public double Direction { get; set; }
    public string OffsetValue { get; set; }
    public double PlateX { get; set; }
    public double PlateY { get; set; }
    public double PlateWidth { get; set; }
    public double PlateHeight { get; set; }
    public string GeofenceBlockId { get; set; }
    public string EnforcementStartTime { get; set; }
    public string EnforcementEndTime { get; set; }
  }
}
