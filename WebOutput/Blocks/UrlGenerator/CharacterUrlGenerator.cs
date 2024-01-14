using System.Security.Cryptography;

namespace WebOutput.Blocks.UrlGenerator;

public class CharacterUrlGenerator : AbstractUrlGenerator
{
    private readonly char[] Characters;
    private readonly int Length;

    public CharacterUrlGenerator(int length, string characters) : this(length, characters.ToCharArray()) { }

    public CharacterUrlGenerator(int length, char[] characters)
    {
        Characters = characters;
        Length = length;
    }

    public override string GenerateNewUrl() => string.Join("", RandomNumberGenerator.GetItems<char>(Characters, Length));
}
