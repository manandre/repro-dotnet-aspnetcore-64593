using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace WebApp.Tests;

public class CustomWebApplicationFactory<T>
    : WebApplicationFactory<T> where T : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseTestServer(o => o.AllowSynchronousIO = true);
    }
}

public class WebAppTests(CustomWebApplicationFactory<Program> factory)
    : IClassFixture<CustomWebApplicationFactory<Program>>
{
    [Fact]
    public void Settings_AllowSynchronousIo_Set()
    {
        Assert.True(factory.Server.AllowSynchronousIO);
    }
}
