using NFSMostWanted.Abstractions;
using NFSMostWanted.Attributes;
using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Models;
using System.Drawing;

namespace NFSMostWanted.Builders.Cars;

[CarBuilder(Brand.Audi, CarModel.AudiA4)]
public class AudiA4CarBuilder : ACarBuilder
{
    public override ICar Build(Color color)
    {
        Car = new Car(Brand.Audi, CarModel.AudiA4, color);

        SetAcceleration(7.3);
        SetBody(BodyType.Sedan);
        SetBrake(BrakeType.ABS);
        SetEngine(EngineType.Petrol);
        SetFuel(FuelType.Premium);
        SetHandling(8.5);
        SetHorsePower(190);
        SetLight(LightType.LED);
        SetSpeed(240);
        SetSuspension(SuspensionType.Sport);
        SetTire(TireType.Sport);

        return Car;
    }
}