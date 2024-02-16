using NFSMostWanted.Abstractions;
using NFSMostWanted.Builders.Cars;
using NFSMostWanted.Constants;

namespace NFSMostWanted.Factories;

public class AudiCarFactory : ACarFactory
{
    public AudiCarFactory()
    {
        Builders.Add(CarModel.AudiA3, new AudiA3CarBuilder());
        Builders.Add(CarModel.AudiA4, new AudiA4CarBuilder());
    }
}
