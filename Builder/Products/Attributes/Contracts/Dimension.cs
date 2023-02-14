namespace AbstractFactory.Products.Attributes.Contracts;

public abstract class Dimension
{
    public enum Metric
    {
        Centimeters,
        Millimeters,
        Meters
    }

    protected Dimension(int value, Metric measurementUnit)
    {
        Value = value;
        MeasurementUnit = measurementUnit;
    }

    public int Value { get; }
    public Metric MeasurementUnit { get; }

    public int GetValueInMillimeters()
    {
        return MeasurementUnit switch
        {
            Metric.Centimeters => Value * 10,
            Metric.Meters => Value * 1000,
            Metric.Millimeters => Value,
            _ => throw new InvalidOperationException("Invalid measurement unit")
        };
    }

    public int GetValueInCentimeters()
    {
        return MeasurementUnit switch
        {
            Metric.Centimeters => Value,
            Metric.Meters => Value / 100,
            Metric.Millimeters => Value * 10,
            _ => throw new InvalidOperationException("Invalid measurement unit")
        };
    }

    public int GetValueInMeters()
    {
        return MeasurementUnit switch
        {
            Metric.Centimeters => Value / 100,
            Metric.Meters => Value,
            Metric.Millimeters => Value / 1000,
            _ => throw new InvalidOperationException("Invalid measurement unit")
        };
    }
}