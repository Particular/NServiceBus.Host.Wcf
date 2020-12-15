﻿using NServiceBus;
using NUnit.Framework;
using Particular.Approvals;
using PublicApiGenerator;

[TestFixture]
public class APIApprovals
{
    [Test]
    public void Approve()
    {
        var publicApi = ApiGenerator.GeneratePublicApi(typeof(WcfSettings).Assembly, excludeAttributes: new [] { "System.Reflection.AssemblyMetadataAttribute" });
        Approver.Verify(publicApi);
    }
}