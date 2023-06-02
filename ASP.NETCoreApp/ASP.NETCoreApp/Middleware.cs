

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;


namespace MyWebApp
{
    public class Middleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<Middleware> _logger;

        public Middleware(RequestDelegate next, ILogger<Middleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            // Log the request information
            string requestMessage = $"Request received: {context.Request.Method} {context.Request.Path}";
            _logger.LogInformation(requestMessage);

            try
            {
                // Call the next middleware in the pipeline
                await _next(context);
            }
            finally
            {
                // Log the response information
                int statusCode = context.Response.StatusCode;
                string responseMessage = $"Request completed: {context.Request.Method} {context.Request.Path} => {statusCode}";
                _logger.LogInformation(responseMessage);
            }
        }
    }
}







