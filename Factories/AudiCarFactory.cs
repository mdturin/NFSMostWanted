using NFSMostWanted.Builders.Cars;
using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class AudiCarFactory : ICarFactory
{
    private readonly Dictionary<string, ICarBuilder> _builders = new()
    {
        { CarModel.AudiA3, new AudiA3CarBuilder() }
    };

    public ICar CreateCar(Brand brand, string model, Color color)
    {
        if(!_builders.TryGetValue(model, out var builder))
        {
            throw new NotImplementedException();
        }

        return builder.Build(color);
    }
}
