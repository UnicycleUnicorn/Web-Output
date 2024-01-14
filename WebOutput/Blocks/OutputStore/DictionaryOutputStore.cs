using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace WebOutput.Blocks.OutputStore;

public class DictionaryOutputStore : AbstractOutputStore
{
    private readonly ConcurrentDictionary<string, string> Storage;

    public DictionaryOutputStore(StringComparer comparer)
    {
        Storage = new ConcurrentDictionary<string, string>(comparer);
    }

    public DictionaryOutputStore(bool CaseSensitive = false) : this(CaseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase) { }

    public override bool Retrieve(string url, [NotNullWhen(true)] out string? data) => Storage.TryGetValue(url, out data);

    public override bool Store(string url, string data) => Storage.TryAdd(url, data);
}
