namespace Furniture.Products.Retro;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class RetroSofa : Sofa
{
    public RetroSofa()
    {
        Color = new Color() { Value = "brown" };
        Width = new Width { Value = 210, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 140, MeasurementUnit = Dimension.Metric.Centimeters };
        Depth = new Depth { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}