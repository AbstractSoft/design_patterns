namespace Flyweight;

// Client code
public class TextEditor
{
    private readonly List<(ICharacterFlyweight, int)> _characters = [];
    private readonly CharacterFlyweightFactory _flyweightFactory = new();

    public void AddCharacter(char character, int position, CharacterFormatting formatting)
    {
        var flyweight = _flyweightFactory.GetCharacterFlyweight(character, formatting);
        _characters.Add((flyweight, position));
    }

    public void DisplayText()
    {
        foreach (var (flyweight, position) in _characters)
        {
            flyweight.Display(position);
        }
    }
}