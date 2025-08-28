using Rampastring.Tools;
using Rampastring.Tools.Extensions;

namespace IniSerializerTests;

internal class Program
{
    static void Main(string[] args)
    {
        TestClass tc = new();
        tc.Name = "Hungry";
        
        IniSerializationOptions ser_options = new()
        { 
            SectionName = tc.Name, 
            WriteEmptyKeys = false, 
            IgnoreProperties = new() { "Name" } 
        };

        IniDeserializationOptions desser_options = new()
        {
            SectionName = tc.Name,
            SkipEmptyKeys = false,
            IgnoreProperties = new() { "Name" }
        };

        var tmp = IniSerializer.Serialize(tc, ser_options);
        
        Console.WriteLine(tmp);

        TestClass? tc2 = IniSerializer.Deserialize<TestClass>(new IniFile(tmp.ToStream()));

        Console.WriteLine(IniSerializer.Serialize(tc2));
    }
}
