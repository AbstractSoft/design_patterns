namespace Flyweight;

// Concrete flyweight class
public class CharacterFlyweight(char character, CharacterFormatting formatting) : ICharacterFlyweight
{
    public void Display(int position)
    {
        Console.ForegroundColor = formatting.Color;
        Console.Write($"[{character}]"); // Displaying the character in square brackets for emphasis
        Console.ResetColor();
        Console.WriteLine($" at position {position} with font '{formatting.Font}'");
    }
}