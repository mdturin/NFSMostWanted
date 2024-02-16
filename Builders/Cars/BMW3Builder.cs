using NFSMostWanted.Abstractions;
using NFSMostWanted.Attributes;
using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Models;
using System.Drawing;

namespace NFSMostWanted.Builders.Cars;

[CarBuilder(Brand.BMW, CarModel.BMW3Series)]
public class BMW3Builder : ACarBuilder
{
    public override ICar Build(Color color)
    {
        Car = new Car(Brand.BMW, CarModel.BMW3Series, color);

        SetAcceleration(5.9);
        SetBody(BodyType.Sedan);
        SetBrake(BrakeType.ABS);
        SetEngine(EngineType.Diesel);
        SetFuel(FuelType.Diesel);
        SetHandling(8.5);
        SetHorsePower(190);
        SetLight(LightType.LED);
        SetSpeed(240);
        SetSuspension(SuspensionType.Sport);
        SetTire(TireType.Sport);

        return Car;
    }
}
