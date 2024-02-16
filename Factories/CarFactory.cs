using NFSMostWanted.Enums;
using NFSMostWanted.Interfaces;
using System.Drawing;

namespace NFSMostWanted.Factories;

public class CarFactory : ICarFactory
{
    public static Dictionary<(Brand, string), ICarBuilder> Builders { get; } = [];

    public ICar CreateCar(Brand brand, string model, Color color)
    {
        return GetCarBuilder(brand, model).Build(color);
    }

    public ICar UpdateCar(ICar car, string typeName, object value)
    {
        return GetCarBuilder(car.Brand, car.Model)
            .UpdateCar(car, typeName, value);
    }

    private static ICarBuilder GetCarBuilder(Brand brand, string model)
    {
        if (!Builders.TryGetValue((brand, model), out var builder))
        {
            throw new NotImplementedException();
        }

        return builder;
    }
}
