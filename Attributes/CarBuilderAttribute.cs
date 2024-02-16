using NFSMostWanted.Enums;

namespace NFSMostWanted.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class CarBuilderAttribute(Brand brand, string model) : Attribute
{
    public Brand Brand { get; } = brand;
    public string Model { get; } = model;
}