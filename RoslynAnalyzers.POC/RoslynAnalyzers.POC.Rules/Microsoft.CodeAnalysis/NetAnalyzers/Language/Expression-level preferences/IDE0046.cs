using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Use conditional expression for return (IDE0046)
    /// </summary>
    public class IDE0046
    {
        public string Test()
        {
            var isValid = true;

            if (isValid)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
