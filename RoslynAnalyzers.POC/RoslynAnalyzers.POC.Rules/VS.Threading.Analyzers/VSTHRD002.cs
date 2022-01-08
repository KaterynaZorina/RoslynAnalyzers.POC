using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD002 Avoid problematic synchronous waits
    /// </summary>
    public class VSTHRD002
    {
        private Task<int> SomeAsyncMethod()
        {
            return Task.FromResult(5);
        }

        public void TestMethod()
        {
            SomeAsyncMethod().Result;
        }
    }
}
