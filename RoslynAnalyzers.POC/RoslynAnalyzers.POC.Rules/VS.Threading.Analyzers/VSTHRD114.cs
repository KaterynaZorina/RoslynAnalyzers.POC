using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD114 Avoid returning a null Task
    /// </summary>
    public class VSTHRD114
    {
        public Task SomeAsyncMethod()
        {
            return null;
        }
    }
}
