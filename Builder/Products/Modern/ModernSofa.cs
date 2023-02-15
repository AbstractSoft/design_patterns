namespace Furniture.Products.Modern;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class ModernSofa : Sofa
{
    public ModernSofa()
    {
        Color = new Color() { Value = "green" };
        Width = new Width { Value = 210, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 140, MeasurementUnit = Dimension.Metric.Centimeters };
        Depth = new Depth { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}