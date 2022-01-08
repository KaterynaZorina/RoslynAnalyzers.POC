using System;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD110 Observe result of async calls
    /// </summary>
    public class VSTHRD110
    {
        public Task SomeAsyncMethod()
        {
            Console.WriteLine();

            return Task.CompletedTask;
        }

        public void TestMethod()
        {
            SomeAsyncMethod();
        }
    }
}
