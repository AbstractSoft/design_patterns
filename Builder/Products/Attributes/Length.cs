namespace Furniture.Products.Attributes;

using Contracts;

public class Length : Dimension
{
    public static Length GetNullValue()
    {
        return new Length { Value = 0 };
    }
}