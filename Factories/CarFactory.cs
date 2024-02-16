using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class CarFactory : ICarFactory
{
    public ICar CreateCar(Brand brand, string model, Color color)
    {
        return brand switch
        {
            Brand.Audi => new AudiCarFactory().CreateCar(brand, model, color),
            _ => throw new NotImplementedException()
        };
    }
}
