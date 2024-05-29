namespace Xaqatalà.Note.StringValue;

public class StringValueAttribute(string stringValue) : Attribute
{
    public string StringValue { get; protected set; } = stringValue;
}