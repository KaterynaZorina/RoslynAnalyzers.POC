using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeAnalysis.NetAnalyzers.Language.Expression_level_preferences
{
    /// <summary>
    /// Use conditional expression for assignment (IDE0045)
    /// </summary>
    public class IDE0045
    {
        public void Test()
        {
            var isValid = true;

            var resultStr = string.Empty;

            if (isValid)
            {
                resultStr = "true";
            }
            else
            {
                resultStr = "false";
            }
        }
    }
}
