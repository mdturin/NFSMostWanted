using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class CarFactory
{
    public static ICar CreateCar(
        Brand brand,
        string model,
        Color color,
        double speed,
        double acceleration,
        double handling)
    {
        return brand switch
        {
            _ => throw new ArgumentException("Invalid car brand.")
        };
    }
}
