namespace Furniture.Products.Classic;

using Attributes;
using Contracts;
using Furniture.Products.Attributes.Contracts;

public class ClassicSofa : Sofa
{
    public ClassicSofa()
    {
        Color = new Color() { Value = "beige" };
        Width = new Width { Value = 210, MeasurementUnit = Dimension.Metric.Centimeters };
        Height = new Height { Value = 140, MeasurementUnit = Dimension.Metric.Centimeters };
        Depth = new Depth { Value = 60, MeasurementUnit = Dimension.Metric.Centimeters };
    }
}