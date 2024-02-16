using NFSMostWanted.Attributes;
using NFSMostWanted.Factories;
using NFSMostWanted.Helpers;
using NFSMostWanted.Interfaces;
using System.Reflection;

namespace NFSMostWanted.Services;

public class CarFactoryService
{
    public static void RegisterAllCarBuilders()
    {
        var carFactoryTypes = AttributeHelper.GetAllTypesFromAttribute<CarBuilderAttribute>();
        foreach (var carFactoryType in carFactoryTypes)
        {
            var type = carFactoryType.GetCustomAttribute<CarBuilderAttribute>();
            if(type != null && Activator.CreateInstance(carFactoryType) is ICarBuilder carBuilder)
            {
                CarFactory.Builders.Add((type.Brand, type.Model), carBuilder);
            }
        }
    }
}
