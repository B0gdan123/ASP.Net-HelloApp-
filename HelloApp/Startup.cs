using HelloApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HelloApp
{
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Інші Middleware

        app.UseMiddleware<CompanyMiddleware>(); // Додаємо наш Middleware

        // Інші Middleware
    }

}
