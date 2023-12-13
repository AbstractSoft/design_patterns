namespace Flyweight;

// Intrinsic state representing the formatting of a character
public class CharacterFormatting(string font, ConsoleColor color)
{
    public string Font { get; } = font;
    public ConsoleColor Color { get; } = color;

    // Other formatting properties and methods can be added as needed
}

// Example Usage
public static class Program
{
    public static void Main()
    {
        var textEditor = new TextEditor();

        // Adding formatted characters to the text editor
        textEditor.AddCharacter('H', 0, new CharacterFormatting("Arial", ConsoleColor.Blue));
        textEditor.AddCharacter('e', 1, new CharacterFormatting("Times New Roman", ConsoleColor.Red));
        textEditor.AddCharacter('l', 2, new CharacterFormatting("Verdana", ConsoleColor.Green));
        textEditor.AddCharacter('l', 3, new CharacterFormatting("Arial", ConsoleColor.Yellow));
        textEditor.AddCharacter('o', 4, new CharacterFormatting("Calibri", ConsoleColor.Magenta));

        // Displaying the formatted text
        textEditor.DisplayText();
    }
}