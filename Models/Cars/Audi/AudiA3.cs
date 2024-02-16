using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Models.Cars.Audi;

public class AudiA3 : ICar
{
    public Brand Brand { get; set; }
    public string Model { get; set; }
    public Color Color { get; set; }
    public int HorsePower { get; set; }
    public double Speed { get; set; }
    public double Acceleration { get; set; }
    public double Handling { get; set; }
    public EngineType Engine { get; set; }
    public TireType Tire { get; set; }
    public BrakeType Brake { get; set; }
    public BodyType Body { get; set; }
    public FuelType Fuel { get; set; }
    public LightType Light { get; set; }
    public SuspensionType Suspension { get; set; }
}
