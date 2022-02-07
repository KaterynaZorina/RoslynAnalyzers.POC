using System.Collections.Concurrent;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1836" (Prefer IsEmpty over Count when available)
    /// </summary>
    public class CA1836
    {
        public void TestCountViolation()
        {
            var c = new IsEmptyOverCountViolation();

        }

        public class IsEmptyOverCountViolation
        {
            private readonly ConcurrentQueue<int> _queue;
            public bool IsEmptyViolation => _queue.Count == 0;

            public bool IsEmptyFix => _queue.IsEmpty;
        }
    }
}
