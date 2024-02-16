using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Models.Cars.Audi;
using System.Drawing;

namespace NFSMostWanted.Builders.Cars;

public class AudiA3CarBuilder : ICarBuilder
{
    private ICar? _car;

    public ICar Build(Color color)
    {
        _car = new AudiA3();

        SetAcceleration(8.2);
        SetBody(BodyType.Hatchback);
        SetBrake(BrakeType.ABS);
        SetBrand(Brand.Audi);
        SetColor(color);
        SetEngine(EngineType.Petrol);
        SetFuel(FuelType.Premium);
        SetHandling(7.5);
        SetHorsePower(150);
        SetLight(LightType.LED);
        SetModel("A3");
        SetSpeed(220);
        SetSuspension(SuspensionType.Sport);
        SetTire(TireType.Sport);

        return _car;
    }

    public ICarBuilder SetAcceleration(double acceleration)
    {
        _car.Acceleration = acceleration;
        return this;
    }

    public ICarBuilder SetBody(BodyType body)
    {
        _car.Body = body;
        return this;
    }

    public ICarBuilder SetBrake(BrakeType brake)
    {
        _car.Brake = brake;
        return this;
    }

    public ICarBuilder SetBrand(Brand brand)
    {
        _car.Brand = brand;
        return this;
    }

    public ICarBuilder SetColor(Color color)
    {
        _car.Color = color;
        return this;
    }

    public ICarBuilder SetEngine(EngineType engine)
    {
        _car.Engine = engine;
        return this;
    }

    public ICarBuilder SetFuel(FuelType fuel)
    {  
        _car.Fuel = fuel;
        return this;
    }

    public ICarBuilder SetHandling(double handling)
    {
        _car.Handling = handling;
        return this;
    }

    public ICarBuilder SetHorsePower(int horsePower)
    {
        _car.HorsePower = horsePower;
        return this;
    }

    public ICarBuilder SetLight(LightType light)
    {
        _car.Light = light;
        return this;
    }

    public ICarBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public ICarBuilder SetSpeed(double speed)
    {
        _car.Speed = speed;
        return this;
    }

    public ICarBuilder SetSuspension(SuspensionType suspension)
    {
        _car.Suspension = suspension;
        return this;
    }

    public ICarBuilder SetTire(TireType tire)
    {
        _car.Tire = tire;
        return this;
    }
}
