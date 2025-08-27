using Rampastring.Tools;

namespace IniSerializerTests;

internal class Program
{
    static void Main(string[] args)
    {
        TestClass tc = new();
        tc.Name = "Hungry";
        var tmp = IniSerializer.Serialize(tc, IniSerializer.DefaultSerializationOptions with { Section = tc.Name });
        Console.WriteLine(tmp);
    }
}
