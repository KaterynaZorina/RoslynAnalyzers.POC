using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Var_preferences
{
    /// <summary>
    /// IDE0007: Use 'var' instead of explicit type
    /// </summary>
    public class IDE0007
    {
        public void Test()
        {
            int number = 10;
        }
    }
}
