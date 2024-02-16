using NFSMostWanted.Abstractions;
using NFSMostWanted.Enums;
using NFSMostWanted.Factories;
using System.Drawing;

namespace NFSMostWanted.Interfaces;

public interface ICarFactory
{
    static Dictionary<(Brand, string), ICarBuilder>? Builders { get; }

    ICar CreateCar(Brand brand, string model, Color color);
}

