namespace AbstractFactory.Products.Attributes;

public class Color
{
    public Color(string value)
    {
        Value = value;
    }

    public string Value { get; }
}