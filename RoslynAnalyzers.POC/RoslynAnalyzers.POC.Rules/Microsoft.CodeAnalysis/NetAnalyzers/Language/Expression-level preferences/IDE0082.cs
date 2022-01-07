using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Convert typeof to nameof (IDE0082)
    /// </summary>
    public class IDE0082
    {
        public void Test()
        {
            var n2 = typeof(int).Name;
        }
    }
}
