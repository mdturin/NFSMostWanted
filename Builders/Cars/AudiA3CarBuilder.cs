using NFSMostWanted.Abstractions;
using NFSMostWanted.Attributes;
using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Models;
using System.Drawing;

namespace NFSMostWanted.Builders.Cars;

[CarBuilder(Brand.Audi, CarModel.AudiA3)]
public class AudiA3CarBuilder : ACarBuilder
{
    public override ICar Build(Color color)
    {
        Car = new Car(Brand.Audi, CarModel.AudiA3, color);

        SetAcceleration(8.2);
        SetBody(BodyType.Hatchback);
        SetBrake(BrakeType.ABS);
        SetEngine(EngineType.Petrol);
        SetFuel(FuelType.Premium);
        SetHandling(7.5);
        SetHorsePower(150);
        SetLight(LightType.LED);
        SetSpeed(220);
        SetSuspension(SuspensionType.Sport);
        SetTire(TireType.Sport);

        return Car;
    }
}