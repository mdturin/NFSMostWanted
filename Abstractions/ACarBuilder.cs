using NFSMostWanted.Enums;
using NFSMostWanted.Helpers;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Abstractions;

public abstract class ACarBuilder : ICarBuilder
{
    protected ICar? Car;

    public abstract ICar Build(Color color);

    public ICar UpdateCar(ICar car, string typeName, object value)
    {
        if (car.Clone() is not ICar updatedCar)
            throw new Exception("Car can't be cloned!");

        var propertyInfo = typeof(ICar).GetProperty(typeName)
            ?? throw new Exception("Property not found!");

        if (!propertyInfo.CanWrite)
            throw new Exception("Property can't be written!");

        if (!TypeHelper.IsAssignable(value, propertyInfo.PropertyType))
            throw new Exception("Value can't be assigned to property!");

        propertyInfo.SetValue(updatedCar, value);

        return updatedCar;
    }

    public ICarBuilder SetAcceleration(double acceleration)
    {
        Car!.Acceleration = acceleration;
        return this;
    }

    public ICarBuilder SetBody(BodyType body)
    {
        Car!.Body = body;
        return this;
    }

    public ICarBuilder SetBrake(BrakeType brake)
    {
        Car!.Brake = brake;
        return this;
    }

    public ICarBuilder SetBrand(Brand brand)
    {
        Car!.Brand = brand;
        return this;
    }

    public ICarBuilder SetColor(Color color)
    {
        Car!.Color = color;
        return this;
    }

    public ICarBuilder SetEngine(EngineType engine)
    {
        Car!.Engine = engine;
        return this;
    }

    public ICarBuilder SetFuel(FuelType fuel)
    {
        Car!.Fuel = fuel;
        return this;
    }

    public ICarBuilder SetHandling(double handling)
    {
        Car!.Handling = handling;
        return this;
    }

    public ICarBuilder SetHorsePower(int horsePower)
    {
        Car!.HorsePower = horsePower;
        return this;
    }

    public ICarBuilder SetLight(LightType light)
    {
        Car!.Light = light;
        return this;
    }

    public ICarBuilder SetModel(string model)
    {
        Car!.Model = model;
        return this;
    }

    public ICarBuilder SetSpeed(double speed)
    {
        Car!.Speed = speed;
        return this;
    }

    public ICarBuilder SetSuspension(SuspensionType suspension)
    {
        Car!.Suspension = suspension;
        return this;
    }

    public ICarBuilder SetTire(TireType tire)
    {
        Car!.Tire = tire;
        return this;
    }
}
