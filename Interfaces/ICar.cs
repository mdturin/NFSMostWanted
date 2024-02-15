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
    Engine Engine { get; set; }
    Tire Tire { get; set; }
    Brake Brake { get; set; }
    Body Body { get; set; }
    Fuel Fuel { get; set; }
    Light Light { get; set; }
    Suspension Suspension { get; set; }
}