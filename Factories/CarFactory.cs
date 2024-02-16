using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class CarFactory : ICarFactory
{
    public static Dictionary<(Brand, string), ICarBuilder> Builders { get; } = [];

    public ICar CreateCar(Brand brand, string model, Color color)
    {
        if (!Builders.TryGetValue((brand, model), out var builder))
        {
            throw new NotImplementedException();
        }

        return builder.Build(color);
    }
}
