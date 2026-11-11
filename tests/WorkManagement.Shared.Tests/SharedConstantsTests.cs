using NUnit.Framework;
using Shouldly;

namespace WorkManagement.Shared.Tests;

[TestFixture]
public class SharedConstantsTests
{
    [Test]
    public void ShouldExposeExpectedServiceIdentifiers()
    {
        Services.Frontend.ShouldBe("frontend");
        Services.Api.ShouldBe("api");
        Services.DatabaseServer.ShouldBe("dbserver");
        Services.Database.ShouldBe("QuanLyCongViecDb");
        Services.HangfireRedis.ShouldBe("HangfireRedis");
        Services.CacheRedis.ShouldBe("CacheRedis");
    }

    [Test]
    public void ShouldExposeExpectedHostingOptionKeys()
    {
        HostingOptions.SectionName.ShouldBe("Hosting");
        HostingOptions.ServeSpa.ShouldBe("ServeSpa");
    }
}

