using renatodavis.app.api.Exceptions;
using System.Text.Json;
namespace renatodavis.app.api
{
    using Microsoft.AspNetCore.Http;   
    using System;
    using System.Threading.Tasks;
    using System.Text.Json;

    namespace renatodavis.app.api
    {
        public class ExceptionMiddleware
        {
            private readonly RequestDelegate _next;

            public ExceptionMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task InvokeAsync(HttpContext httpContext)
            {
                try
                {
                    await _next(httpContext);
                }
                catch (ApiException ex)
                {
                    await HandleExceptionAsync(httpContext, ex);
                }
                catch (Exception ex)
                {
                    await HandleExceptionAsync(httpContext, new ApiException(500, "Ocorreu um erro interno." + ex.Message + ' ' + ex.InnerException, ex));
                }
            }

            private static Task HandleExceptionAsync(HttpContext context, ApiException exception)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = exception.ErrorCode;

                var result = JsonSerializer.Serialize(new
                {
                    StatusCode = context.Response.StatusCode,
                    Message = exception.Message
                });

                return context.Response.WriteAsync(result);
            }
        }
    }


}
