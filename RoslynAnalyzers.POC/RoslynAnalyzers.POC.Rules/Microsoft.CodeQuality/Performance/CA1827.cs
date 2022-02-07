using System.Collections.Generic;
using System.Linq;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1827" (Do not use Count/LongCount when Any can be used)
    /// </summary>
    public class CA1827
    {
        public void TestCountViolation()
        {
            var a = new LongCountViolation();
        }
    }

    //Rule violation
    public class LongCountViolation
    {
        public string ViolateCount(IEnumerable<string> list)
            => list.Count() != 0 ? "Not empty" : "Empty";

        public string ViolateLongCount(IEnumerable<string> list)
            => list.LongCount() > 0 ? "Not empty" : "Empty";

        public string CountFix(IEnumerable<string> list)
           => list.Any() ? "Not empty" : "Empty";

        public string LongCountFix(IEnumerable<string> list)
            => list.Any() ? "Not empty" : "Empty";
    }
}
