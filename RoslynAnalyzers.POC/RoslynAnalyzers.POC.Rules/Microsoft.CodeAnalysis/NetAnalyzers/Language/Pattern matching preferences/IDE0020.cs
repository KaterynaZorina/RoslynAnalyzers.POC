using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Pattern_matching_preferences
{
    /// <summary>
    /// Use pattern matching to avoid 'is' check followed by a cast (IDE0020)
    /// </summary>
    public class IDE0020
    {
        public void Test()
        {
            object o = 123;
            if (o is int)
            {
                var i = (int)o;
            }
        }
    }
}
