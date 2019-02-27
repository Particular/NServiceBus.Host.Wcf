namespace NServiceBus.Core.Tests.API
{
    using Features;
    using NUnit.Framework;
    using Particular.Approvals;
    using PublicApiGenerator;

    [TestFixture]
    public class APIApprovals
    {
        [Test]
        public void ApproveWcfSupport()
        {
            var publicApi = ApiGenerator.GeneratePublicApi(typeof(WcfSupport).Assembly);
            Approver.Verify(publicApi);
        }
    }
}