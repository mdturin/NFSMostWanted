namespace NFSMostWanted.Interfaces;

public interface ICar
{
    string Brand { get; set; }
    string Model { get; set; }
    double Speed { get; set; }
    double Acceleration { get; set; }
    double Handling { get; set; }
}