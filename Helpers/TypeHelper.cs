namespace NFSMostWanted.Helpers;

public class TypeHelper
{
    public static bool IsAssignable(object value, Type targetType)
    {
        try
        {
            object result = Convert.ChangeType(value, targetType);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
