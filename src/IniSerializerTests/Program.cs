using Rampastring.Tools;

namespace IniSerializerTests;

internal class Program
{
    static void Main(string[] args)
    {
        TestClass tc = new TestClass();
        var tmp = IniSerializer.Serialize<TestClass>(tc);
        Console.WriteLine("Hello, World!");
    }
}
