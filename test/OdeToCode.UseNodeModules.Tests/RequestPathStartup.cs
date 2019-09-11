namespace OdeToCode.UseNodeModules.Tests
{
    using System;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;

    public class RequestPathStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseNodeModules(TimeSpan.FromSeconds(600), "/vendor");
        }
    }
}
