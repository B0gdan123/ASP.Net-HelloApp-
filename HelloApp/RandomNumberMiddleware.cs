namespace HelloApp;

   using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

public class RandomNumberMiddleware
{
    private readonly RequestDelegate _next;

    public RandomNumberMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Логіка для завдання 2
        var random = new Random();
        int randomNumber = random.Next(0, 101);

        // Відправляємо випадкове число клієнту
        context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync(randomNumber.ToString());
    }
}
 
