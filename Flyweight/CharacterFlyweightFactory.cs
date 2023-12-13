namespace Flyweight;

// Flyweight factory
public class CharacterFlyweightFactory
{
    private readonly Dictionary<char, ICharacterFlyweight> _flyweights = new();

    public ICharacterFlyweight GetCharacterFlyweight(char character, CharacterFormatting formatting)
    {
        if (!_flyweights.ContainsKey(character))
        {
            _flyweights[character] = new CharacterFlyweight(character, formatting);
        }
        return _flyweights[character];
    }
}