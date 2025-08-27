using Rampastring.Tools;

namespace IniSerializerTests;

internal class Program
{
    static void Main(string[] args)
    {
        TestClass tc = new();
        tc.Name = "Hungry";
        var options = IniSerializer.DefaultSerializationOptions with { SectionName = tc.Name, WriteEmptyKeys = false, IgnoreProperties = new() { "Name" } };
        var tmp = IniSerializer.Serialize(tc, options);
        Console.WriteLine(tmp);
    }
}
