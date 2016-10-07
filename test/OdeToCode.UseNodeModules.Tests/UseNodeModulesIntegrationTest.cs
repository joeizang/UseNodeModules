using System.IO;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace OdeToCode.UseNodeModules.Tests
{
    public class UseNodeModulesIntegrationTest
    {
        [Fact]
        public async void RespondsToFileInNodeModules()
        {
            var builder = new WebHostBuilder();
            builder.UseContentRoot(Directory.GetCurrentDirectory());
            builder.UseStartup<TestStartup>();
            var server = new TestServer(builder);
            var client = server.CreateClient();

            var result = await client.GetStringAsync("/node_modules/hello.txt");

            Assert.Equal("hello!", result);
        }

        [Fact]
        public async void IgnoresOutOfNodeModules()
        {
            var builder = new WebHostBuilder();
            builder.UseContentRoot(Directory.GetCurrentDirectory());
            builder.UseStartup<TestStartup>();
            var server = new TestServer(builder);
            var client = server.CreateClient();

            var result = await client.GetAsync("hello.txt");

            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
        }
    }
}
