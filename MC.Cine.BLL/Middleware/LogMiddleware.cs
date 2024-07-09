using MC.Cine.BLL.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;

namespace MC.Cine.BLL.Middleware
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LogMiddleware(RequestDelegate next, ILogger<LogMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context != null)
            {
                var method = context.Request.Path;

                try
                {
                    _logger.LogInformation("Inicia ejecución del método {Method}.", method);

                    await _next(context);

                    var statusCode = context.Response.StatusCode;
                    _logger.LogInformation("Finaliza ejecución del método {Method}. Status code {StatusCode}.", method, statusCode);
                }
                catch (Exception ex)
                {
                    const int statusCodeError = (int)HttpStatusCode.InternalServerError;
                    _logger.LogError(ex, "Ocurrió un error en el método {Method}. Status code {StatusCode}.", method, statusCodeError);
                    await HandleGlobalExcepcionAsync(context);
                }
            }
        }

        /// <summary>
        /// Manejador global de excepciones
        /// </summary>
        /// <param name="context">Contexto</param>
        /// <param name="ex">Excepcion</param>
        /// <returns>Response</returns>
        private static Task HandleGlobalExcepcionAsync(HttpContext context)
        {
            //Modifico el response
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            //Cargo el objeto en caso de ser Excepcion
            ResponseDetails response = new ResponseDetails
            {
                Success = false,
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
