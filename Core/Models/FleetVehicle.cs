namespace Core.Models;

public class FleetVehicle : BaseModel
{
    public required Status Status { get; set; }
    public required string LicensePlate { get; set; }
    public required DateOnly RegistrationDate { get; set; }
}

public enum Status
{
    Available,
    InUse,
    Stolen
}