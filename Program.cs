using NFSMostWanted.Constants;
using NFSMostWanted.Enums;
using NFSMostWanted.Factories;
using NFSMostWanted.Interfaces;
using NFSMostWanted.Services;
using System.Drawing;

namespace NFSMostWanted;

public class Program
{
    public static void Main( string[] args )
    {
        CarFactoryService.RegisterAllCarBuilders();

        var carFactory = new CarFactory();
        var audiA3BlackCar = carFactory.CreateCar(Brand.Audi, CarModel.AudiA3, Color.Black);
        var audiA4RedCar = carFactory.CreateCar(Brand.Audi, CarModel.AudiA4, Color.Red);
        var bmw3SeriesWhiteCar = carFactory.CreateCar(Brand.BMW, CarModel.BMW3Series, Color.White);
        var fordGT40BlueCar = carFactory.CreateCar(Brand.Ford, CarModel.FordGT40, Color.Blue);

        Console.WriteLine(audiA3BlackCar);
        Console.WriteLine("----------------------");
        Console.WriteLine(audiA4RedCar);
        Console.WriteLine("----------------------");
        Console.WriteLine(bmw3SeriesWhiteCar);
        Console.WriteLine("----------------------");
        Console.WriteLine(fordGT40BlueCar);
        Console.WriteLine("----------------------");

        var newAudiA3BlackCar = carFactory
            .UpdateCar(audiA3BlackCar, nameof(ICar.Suspension), SuspensionType.Racing);

        Console.WriteLine(newAudiA3BlackCar);
        Console.WriteLine("----------------------");

        audiA3BlackCar.Engine = EngineType.V8;
        Console.WriteLine(audiA3BlackCar.Engine + " " + newAudiA3BlackCar.Engine);
    }
}