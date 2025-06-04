using Core.Models;

namespace API.Dtos;

public class FleetVehicleDto
{
    public required string Status { get; set; }
    public required string LicensePlate { get; set; }
    public required DateOnly RegistrationDate { get; set; }
}