using Rampastring.Tools;
using Rampastring.Tools.Extensions;

namespace IniSerializerTests;

internal class Program
{
    static void Main(string[] args)
    {
        IniSerializer iniSerializer = new(new ConversionsExtension());
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

        var tmp = iniSerializer.Serialize(tc);
        
        Console.WriteLine(tmp);

        TestClass? tc2 = iniSerializer.Deserialize<TestClass>(tmp, IniSerializer.DefaultDeserializationOptions with { 
            SectionName=nameof(TestClass), SkipUnableToParseTypes = false }); 

        Console.WriteLine(iniSerializer.Serialize(tc2));
    }
}
