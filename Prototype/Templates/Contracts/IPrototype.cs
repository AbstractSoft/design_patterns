namespace Prototype.Templates.Contracts;

public interface IPrototype<out T>
{
    public T Clone();
}