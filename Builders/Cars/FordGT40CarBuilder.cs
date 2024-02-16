using NFSMostWanted.Abstractions;
using NFSMostWanted.Attributes;
using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Models;
using System.Drawing;

namespace NFSMostWanted.Builders.Cars;

[CarBuilder(Brand.Ford, CarModel.FordGT40)]
public class FordGT40CarBuilder : ACarBuilder
{
    public override ICar Build(Color color)
    {
        Car = new Car(Brand.Ford, CarModel.FordGT40, color);

        SetAcceleration(3.2);
        SetBody(BodyType.Coupe);
        SetBrake(BrakeType.CarbonCeramic);
        SetEngine(EngineType.V8);
        SetFuel(FuelType.Petrol);
        SetHandling(3.5);
        SetHorsePower(335);
        SetLight(LightType.LED);
        SetSpeed(330);
        SetSuspension(SuspensionType.Sport);
        SetTire(TireType.Sport);

        return Car;
    }
}
