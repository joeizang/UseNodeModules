using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace OdeToCode.UseNodeModules.Tests
{
    public class TestStartup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            app.UseNodeModules(environment);
        }
    }
}
