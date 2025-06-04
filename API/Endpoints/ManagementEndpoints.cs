using API.Dtos;
using Core.Interfaces;
using Core.Models;

namespace API.Endpoints;

public static class ManagementEndpoints
{
    public static void MapManagementEndpoints(this WebApplication app)
    {
        app.MapPost("/fleetvehicles", async (IUnitOfWork unit, FleetVehicleDto fleetVehicleDto) =>
        {
            var fv = Helpers.ManagementHelpers.CreateNewFleetVehicle(fleetVehicleDto);
            unit.Repository<FleetVehicle>().Add(fv);
            var hasOrderBeenCreated = await unit.Complete();
            if (hasOrderBeenCreated <= 0)
            {
                return Results.BadRequest("Could not create new fleet vehicle");
            }
            return Results.Ok(fv);
        });
    }
}