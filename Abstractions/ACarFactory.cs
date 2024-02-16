using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Abstractions;

public abstract class ACarFactory : ICarFactory
{
    protected readonly Dictionary<string, ICarBuilder> Builders = [];
    public ICar CreateCar(Brand brand, string model, Color color)
    {
        if (!Builders.TryGetValue(model, out var builder))
        {
            throw new NotImplementedException();
        }

        return builder.Build(color);
    }
}
