using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Parentheses_preferences
{
    /// <summary>
    /// Parentheses preferences (IDE0047 and IDE0048)
    /// dotnet_style_parentheses_in_arithmetic_binary_operators
    /// </summary>
    public class IDE0048
    {
        public int Calculate()
        {
            var a = 10;
            var b = 15;
            var c = 20;

            var result = a + b * c;

            return result;
        }
    }
}
