using API.Dtos;
using API.Endpoints;
using API.Helpers;
using Core.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace webcar_tester;

[TestFixture]
public class ManagementVehicles
{
    private FleetVehicleDto _fv;
    [SetUp]
    public void Setup()
    {
        _fv = new FleetVehicleDto
        {
            LicensePlate = "GX4567D",
            RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
            Status = "Available", 
        };
        
    }
    [Test]
    public void ManagementAddsFleetVehicle()
    {
        Assert.That(ManagementHelpers.CreateNewFleetVehicle(_fv), Is.Not.EqualTo(null));
    }
}