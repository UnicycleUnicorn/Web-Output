using System.Linq;
using System.Security.Cryptography;

namespace WebOutput.Blocks.UrlGenerator;

public class NameUrlGenerator : AbstractUrlGenerator
{
    private readonly string[][] Names;
    private readonly string Seperator;

    public NameUrlGenerator(string seperator, params string[][] names)
    {
        Seperator = seperator;
        Names = names;
    }

    public override string GenerateNewUrl()
    {
        string[] names = new string[Names.Length];
        for (int listIndex = 0; listIndex < Names.Length; listIndex++)
        {
            names[listIndex] = Names[listIndex][RandomNumberGenerator.GetInt32(0, Names[listIndex].Length)];
        }
        return string.Join(Seperator, names);
    }
}
