using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class CarFactory : ICarFactory
{
    private readonly Dictionary<Brand, ICarFactory> _factories = new()
    {
        { Brand.Audi, new AudiCarFactory() }
    };

    public ICar CreateCar(Brand brand, string model, Color color)
    {
        if(!_factories.TryGetValue(brand, out var factory))
        {
            throw new NotImplementedException();
        }

        return factory.CreateCar(brand, model, color);
    }
}
