namespace Furniture.Products.Classic;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class ClassicCoffeeTable : CoffeeTable
{
    public ClassicCoffeeTable()
    {

        Color = new Color() { Value = "beige" };
        Width = new Width { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 80, MeasurementUnit = Dimension.Metric.Centimeters };
        Length = new Length { Value = 100, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}