using API.Dtos;
using Core.Models;

namespace API.Helpers;

public static class ManagementHelpers
{
    public static FleetVehicle CreateNewFleetVehicle(FleetVehicleDto dto)
    {
        return new FleetVehicle
        {
            Status = Enum.Parse<Status>(dto.Status),
            LicensePlate = dto.LicensePlate,
            RegistrationDate = dto.RegistrationDate
        };
        
    }
    
}