using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class CompanyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly Company _company; // Створення екземпляру Company для використання в Middleware

    public CompanyMiddleware(RequestDelegate next)
    {
        _next = next;
        _company = new Company
        {
            Name = "Example Company",
            Address = "123 Main St",
            YearFounded = 2000
        };
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Якщо запит нашого Middleware, повертаємо випадкове число від 0 до 100
        if (context.Request.Path == "/company")
        {
            context.Response.ContentType = "application/json";
            var random = new Random();
            var randomNumber = random.Next(0, 101); // Генеруємо випадкове число
            await context.Response.WriteAsync($"Random Number: {randomNumber}");
        }
        else
        {
            // Інакше передаємо обробку наступному Middleware
            await _next(context);
        }
    }

}
