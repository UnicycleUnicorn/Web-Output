using System.Diagnostics.CodeAnalysis;

namespace WebOutput.Blocks.OutputStore;

public abstract class AbstractOutputStore
{
    public abstract bool Store(string url, string data);

    public abstract bool Retrieve(string url, [NotNullWhen(true)] out string? data);
}
