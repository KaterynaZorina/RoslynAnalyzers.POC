using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD200 Use Async suffix for async methods
    /// </summary>
    public class VSTHRD200
    {
        public Task SomeMethod()
        {
            return Task.CompletedTask;
        }
    }
}
