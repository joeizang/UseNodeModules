# UseNodeModules
ASP.NET Core middleware to serve files from the node_modules directory in the root of the project. 

[![Build status](https://ci.appveyor.com/api/projects/status/cd9v77jdkffwrl1e?svg=true)](https://ci.appveyor.com/project/OdeToCode/usenodemodules)

### Installation
```
    Install-Package OdeToCode.UseNodeModules 
```

### Usage 
```c#
    public class Startup
    {
        // ...

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment)
        {
            // ...

            app.UseNodeModules(environment);

            // ...
        }
    }
```