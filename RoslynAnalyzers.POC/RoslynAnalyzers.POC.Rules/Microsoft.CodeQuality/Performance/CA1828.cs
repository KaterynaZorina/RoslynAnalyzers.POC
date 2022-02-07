using System.Linq;
using System.Threading.Tasks;

namespace RoslynAnalyzers.POC.Rules.Microsoft.CodeQuality.Performance
{
    /// <summary>
    /// Rule ID: "CA1828" (Do not use CountAsync/LongCountAsync when AnyAsync can be used)
    /// </summary>
    public class CA1828
    {
        public void TestCountAsyncViolation()
        {
            var c = new CountAsyncViolation();
        }
    }

    public class CountAsyncViolation
    {
        public async Task<string> ViolateCountAsync(IQueryable<string> list)
            => await list.CountAsync() != 0 ? "Not empty" : "Empty";

        public async Task<string> ViolateLongCountAsync(IQueryable<string> list)
            => await list.LongCountAsync() > 0 ? "Not empty" : "Empty";

        public async Task<string> FixCountAsync(IQueryable<string> list)
        {
            return await list.AnyAsync() ? "Not empty" : "Empty";
        }

        public async Task<string> FixLongCountAsync(IQueryable<string> list)
            => await list.AnyAsync() ? "Not empty" : "Empty";
    }
}
