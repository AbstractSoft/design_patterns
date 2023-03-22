namespace Furniture.Products.Attributes;

public class Color
{
    private const string defaultColor = "white";

    public string Value { get; init; } = defaultColor;

    public static Color GetNullValue()
    {
        return new Color { Value = defaultColor };
    }
}