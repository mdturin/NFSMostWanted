using NFSMostWanted.Enums;
using System.Drawing;

namespace NFSMostWanted.Interfaces;

public interface ICar
{
    CarBrand Brand { get; set; }
    string Model { get; set; }
    Color Color { get; set; }
    double Speed { get; set; }
    double Acceleration { get; set; }
    double Handling { get; set; }
}