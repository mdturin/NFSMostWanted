using NFSMostWanted.Enums;
using System.Drawing;
using System.Reflection;

namespace NFSMostWanted.Interfaces;

public interface ICarBuilder
{
    ICarBuilder SetBrand(Brand brand);
    ICarBuilder SetModel(string model);
    ICarBuilder SetColor(Color color);
    ICarBuilder SetHorsePower(int horsePower);
    ICarBuilder SetSpeed(double speed);
    ICarBuilder SetAcceleration(double acceleration);
    ICarBuilder SetHandling(double handling);
    ICarBuilder SetEngine(EngineType engine);
    ICarBuilder SetTire(TireType tire);
    ICarBuilder SetBrake(BrakeType brake);
    ICarBuilder SetBody(BodyType body);
    ICarBuilder SetFuel(FuelType fuel);
    ICarBuilder SetLight(LightType light);
    ICarBuilder SetSuspension(SuspensionType suspension);
    ICar Build(Color color);
    ICar UpdateCar(ICar car, string typeName, object value);
}

