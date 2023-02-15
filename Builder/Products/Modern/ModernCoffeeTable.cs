namespace Furniture.Products.Modern;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class ModernCoffeeTable : CoffeeTable
{
    public ModernCoffeeTable()
    {
        Color = new Color() { Value = "green" };
        Width = new Width { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 80, MeasurementUnit = Dimension.Metric.Centimeters };
        Length = new Length { Value = 100, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}