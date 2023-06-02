//namespace TaskManagerSystem
//{
//    public class Startup
//    {
//    }
//}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // ConfigureServices method is used to configure services.
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure services here.
    }

    // Configure method is used to configure the request processing pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure request pipeline here.
    }
}

