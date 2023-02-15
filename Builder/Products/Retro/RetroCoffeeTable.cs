namespace Furniture.Products.Retro;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class RetroCoffeeTable : CoffeeTable
{    
    public RetroCoffeeTable()
    {
        Color = new Color() { Value = "brown" };
        Width = new Width { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 80, MeasurementUnit = Dimension.Metric.Centimeters };
        Length = new Length { Value = 100, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}