using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rampastring.Tools;

namespace IniSerializerTests;

public class ConversionsExtension : Conversions
{
    public new object ValueFromString(string str, Type type)
    {
        return base.ValueFromString(str, type);
    }
}
