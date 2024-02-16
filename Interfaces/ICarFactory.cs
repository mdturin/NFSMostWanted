using NFSMostWanted.Enums;
using System.Drawing;

namespace NFSMostWanted.Interfaces;

public interface ICarFactory
{
    ICar CreateCar(Brand brand, string model, Color color);
}

