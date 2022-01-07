using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Pattern_matching_preferences
{
    /// <summary>
    /// Use pattern matching to avoid 'as' followed by a 'null' check (IDE0019)
    /// </summary>
    public class IDE0019
    {
        public void Test()
        {
            object o = null;
            var s = o as string;
            if (s != null)
            {

            }
        }
    }
}
