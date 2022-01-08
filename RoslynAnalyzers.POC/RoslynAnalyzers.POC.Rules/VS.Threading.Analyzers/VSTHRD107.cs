using System.Threading;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD107 Await Task within using expression
    /// </summary>
    public class VSTHRD107
    {
        public Task TestAsyncMethod()
        {
            var lck = new SemaphoreSlim(1);
            using (lck.WaitAsync())
            {

            }

            return Task.CompletedTask;
        }
    }
}
