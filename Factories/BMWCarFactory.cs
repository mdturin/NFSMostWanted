using NFSMostWanted.Abstractions;
using NFSMostWanted.Builders.Cars;
using NFSMostWanted.Constants;

namespace NFSMostWanted.Factories;

public class BMWCarFactory : ACarFactory
{
    public BMWCarFactory()
    {
        Builders.Add(CarModel.BMW3Series, new BMW3Builder());
    }
}
