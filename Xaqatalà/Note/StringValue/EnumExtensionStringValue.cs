using System.Reflection;

namespace Xaqatalà.Note.StringValue;

public static class EnumExtensionStringValue
{
    public static string? GetStringValue(this Enum value)
    {
        Type type = value.GetType();

        FieldInfo? fieldInfo = type.GetField(value.ToString());

        StringValueAttribute[] attribs =
            fieldInfo?.GetCustomAttributes(typeof(StringValueAttribute), false)
                as StringValueAttribute[] ?? [];

        return attribs.Length > 0 ? attribs[0].StringValue : null;
    }
    
}