using System;
using System.Text.RegularExpressions;

namespace Bddify.Core
{
    public class NetToString
    {
        public static Func<string, string> FromUnderscoreSeparatedWords = methodName => string.Join(" ", methodName.Split(new[] { '_' }));
        public static Func<string, string> FromCamelName = name => Regex.Replace(name, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLower(m.Value[1]));
        public static Func<string, string> FromName = name => FromCamelName(FromUnderscoreSeparatedWords(name));
        public static Func<string, string> FromTypeName = FromName;
    }
}