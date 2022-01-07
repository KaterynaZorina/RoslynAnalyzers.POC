using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Code_block_preferences
{
    /// <summary>
    /// Add braces (IDE0011)
    /// </summary>
    public class IDE0011
    {
        public void Test()
        {
            var a = string.Empty;
            if (1 == null)
                Console.WriteLine("Is not null");
        }
    }
}
