using WebOutput.Blocks.OutputStore;
using WebOutput.Blocks.UrlGenerator;

namespace WebOutput;

public static class Application
{
    // Settings
    public static string BaseUrl;

    // Building Blocks
    public static readonly AbstractUrlGenerator UrlGenerator;
    public static readonly AbstractOutputStore OutputStore;

    static Application()
    {
        BaseUrl = "https://localhost:7019";
        UrlGenerator = new CharacterUrlGenerator(5, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        /*
        UrlGenerator = new NameUrlGenerator("-", ["Swift", "Dazzling", "Cozy", "Gleaming", "Radiant", "Pristine", "Mystic", "Vibrant", "Agile", "Majestic", "Tranquil", "Dynamic", "Lively", "Stellar", "Harmonic", "Serene", "Enchanting", "Whimsical", "Jubilant", "Ethereal", "Zesty", "Nebulous", "Quirky", "Resilient", "Sparkling", "Tenacious", "Jubilant", "Piquant", "Jubilant", "Luminous", "Spirited", "Tenacious", "Vivacious", "Whimsical", "Resilient", "Gleaming", "Dynamic", "Zesty", "Nebulous", "Radiant", "Tranquil", "Lively", "Stellar", "Harmonic", "Agile", "Ethereal", "Pristine", "Cozy", "Mystic", "Swift"]
, ["Soar", "Illuminate", "Traverse", "Ignite", "Radiate", "Enchant", "Propel", "Inspire", "Resonate", "Evolve", "Conquer", "Blossom", "Emerge", "Envision", "Embark", "Flourish", "Transcend", "Illuminate", "Radiate", "Ignite", "Blossom", "Emerge", "Propel", "Conquer", "Traverse", "Enchant", "Inspire", "Resonate", "Evolve", "Embark", "Flourish", "Transcend", "Envision", "Soar", "Illuminate", "Radiate", "Inspire", "Propel", "Traverse", "Conquer", "Blossom", "Emerge", "Enchant", "Resonate", "Evolve", "Embark", "Flourish", "Transcend", "Envision", "Radiate"]
, ["Phoenix", "Cascade", "Quasar", "Pinnacle", "Nexus", "Horizon", "Cascade", "Odyssey", "Venture", "Zenith", "Harmony", "Nebula", "Kaleidoscope", "Catalyst", "Aegis", "Quest", "Apex", "Epoch", "Velocity", "Solstice", "Pegasus", "Odyssey", "Labyrinth", "Aether", "Paragon", "Panorama", "Zenith", "Catalyst", "Luminary", "Celestial", "Astral", "Vertex", "Quasar", "Horizon", "Prism", "Utopia", "Arcadia", "Eclipse", "Nexus", "Equinox", "Utopia", "Elysium", "Serenity", "Paragon", "Zenith", "Nebula", "Cascade", "Pinnacle", "Odyssey", "Pegasus"]
);*/
        OutputStore = new DictionaryOutputStore();
    }
}
