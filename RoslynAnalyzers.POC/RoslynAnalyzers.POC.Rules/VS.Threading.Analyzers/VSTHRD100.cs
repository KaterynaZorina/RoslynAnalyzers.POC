namespace RoslynAnalyzers.POC.Rules.VS.Threading.Analyzers
{
    /// <summary>
    /// VSTHRD100 Avoid async void methods
    /// </summary>
    public class VSTHRD100
    {
        private async void Test() { }
    }
}
