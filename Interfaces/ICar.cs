using NFSMostWanted.Enums;
using System.Drawing;

namespace NFSMostWanted.Interfaces;

public interface ICar
{
    Brand Brand { get; set; }
    string Model { get; set; }
    Color Color { get; set; }
    int HorsePower { get; set; }
    double Speed { get; set; }
    double Acceleration { get; set; }
    double Handling { get; set; }
    EngineType Engine { get; set; }
    TireType Tire { get; set; }
    BrakeType Brake { get; set; }
    BodyType Body { get; set; }
    FuelType Fuel { get; set; }
    LightType Light { get; set; }
    SuspensionType Suspension { get; set; }
}