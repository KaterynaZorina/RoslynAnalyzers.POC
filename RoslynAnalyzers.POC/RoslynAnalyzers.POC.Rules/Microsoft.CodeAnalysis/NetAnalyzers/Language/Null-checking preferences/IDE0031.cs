using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Null_checking_preferences
{
    /// <summary>
    /// Use null propagation (IDE0031)
    /// </summary>
    public class IDE0031
    {
        public void Test()
        {
            var o = string.Empty;
            var v = o != null ? o.ToString() : null;
        }
    }
}
