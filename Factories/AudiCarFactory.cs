using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class AudiCarFactory : ICarFactory
{
    public ICar CreateCar(Brand brand, string model, Color color)
    {
        return model switch
        {
            CarModel.AudiA3 => new AudiA3
            {
                Brand = brand,
                Model = model,
                Color = color,
                HorsePower = 150,
                Speed = 220,
                Acceleration = 7.2,
                Handling = 7.5,
                Engine = new Engine
                {
                    Type = EngineType.Petrol,
                    Displacement = 1.5,
                    Turbo = true
                },
                Tire = new Tire
                {
                    Type = TireType.Sport,
                    Size = 17
                },
                Brake = new Brake
                {
                    Type = BrakeType.Sport,
                    Size = 300
                },
                Body = new Body
                {
                    Type = BodyType.Hatchback,
                    Weight = 1200
                },
                Fuel = new Fuel
                {
                    Type = FuelType.Petrol,
                    Capacity = 50
                },
                Light = LightType.LED,
                Suspension = SuspensionType.Sport
            },
            _ => throw new NotImplementedException()
        };
    }
}
