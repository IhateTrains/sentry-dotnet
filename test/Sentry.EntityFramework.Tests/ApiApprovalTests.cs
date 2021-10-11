using System.Threading.Tasks;
using Sentry.Tests;
using VerifyXunit;
using Xunit;

namespace Sentry.EntityFramework.Tests
{
    [UsesVerify]
    public class ApiApprovalTests
    {
        [Fact]
        public Task Run()
        {
            return typeof(SentryDatabaseLogging).Assembly.CheckApproval();
        }
    }
}
