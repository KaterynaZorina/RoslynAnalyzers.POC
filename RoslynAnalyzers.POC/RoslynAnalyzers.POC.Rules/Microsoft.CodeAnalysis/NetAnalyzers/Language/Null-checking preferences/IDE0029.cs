using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Null_checking_preferences
{
    public class IDE0029
    {
        public void Test()
        {
            var a = string.Empty;
            var b = string.Empty;
            var c = a == null ? b : a;
        }
    }
}
