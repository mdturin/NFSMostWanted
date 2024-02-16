using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Models;

public class Car(Brand brand, string model, Color color) : ICar
{
    public Brand Brand { get; set; } = brand;
    public string Model { get; set; } = model;
    public Color Color { get; set; } = color;
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

    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Color: {Color}, HorsePower: {HorsePower}, Speed: {Speed}, Acceleration: {Acceleration}, Handling: {Handling}, Engine: {Engine}, Tire: {Tire}, Brake: {Brake}, Body: {Body}, Fuel: {Fuel}, Light: {Light}, Suspension: {Suspension}";
    }
}
