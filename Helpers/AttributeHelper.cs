using System.Reflection;

namespace NFSMostWanted.Helpers;

public static class AttributeHelper
{
    public static IEnumerable<Type> GetAllTypesFromAttribute<T>() 
        where T : Attribute
    {
        var types = Assembly
            .GetExecutingAssembly().GetTypes();

        var attributedTypes = types
            .Where(t => t.GetCustomAttribute<T>() != null);

        return attributedTypes;
    }
}
