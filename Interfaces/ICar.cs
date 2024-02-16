using NFSMostWanted.Enums;
using System.Drawing;

namespace NFSMostWanted.Interfaces;

public interface ICar
{
    Brand Brand { get; }
    string Model { get; }
    Color Color { get; }
    int HorsePower { get; }
    double Speed { get; }
    double Acceleration { get; }
    double Handling { get; }
    EngineType Engine { get; }
    TireType Tire { get; }
    BrakeType Brake { get; }
    BodyType Body { get; }
    FuelType Fuel { get; }
    LightType Light { get; }
    SuspensionType Suspension { get; }
}