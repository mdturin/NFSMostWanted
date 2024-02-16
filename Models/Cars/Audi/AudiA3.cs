using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Models.Cars.Audi;

public class AudiA3(Color color) : ICar
{
    public Brand Brand { get; private set; } = Brand.Audi;
    public string Model { get; private set; } = CarModel.AudiA3;
    public Color Color { get; private set; } = color;
    public int HorsePower { get; private set; } = 150;
    public double Speed { get; private set; } = 220;
    public double Acceleration { get; private set; } = 7.2;
    public double Handling { get; private set; } = 7.5;
    public EngineType Engine { get; private set; } = EngineType.Audi_TSFI;
    public TireType Tire { get; private set; } = TireType.Sport;
    public BrakeType Brake { get; private set; } = BrakeType.Sport;
    public BodyType Body { get; private set; } = BodyType.Hatchback;
    public FuelType Fuel { get; private set; } = FuelType.Petrol;
    public LightType Light { get; private set; } = LightType.LED;
    public SuspensionType Suspension { get; private set; } = SuspensionType.Sport;
}
