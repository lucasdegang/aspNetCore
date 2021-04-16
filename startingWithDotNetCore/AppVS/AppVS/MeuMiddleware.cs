using AppVS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace AppVS
{
    public class MeuMiddleware
    {
        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // midleware
        public async Task InvokeAsync(HttpContext context)
        {
            // pipeline

            Console.WriteLine("\n\r ----- Antes --- \n\r");
            
            await _next(context);

            Console.WriteLine("\n\r ----- Depois --- \n\r");
        }
    }
}

public static class MeuMiddlewareExtension
{
    public static IApplicationBuilder UseMeuMidleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MeuMiddleware>();
    }
}