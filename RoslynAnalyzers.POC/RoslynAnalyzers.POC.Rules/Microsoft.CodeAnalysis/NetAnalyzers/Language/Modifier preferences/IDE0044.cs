using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Modifier_preferences
{
    /// <summary>
    /// Add readonly modifier (IDE0044)
    /// </summary>
    public class IDE0044
    {
        private int _someNumber = 15;
    }
}
