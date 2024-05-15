using System.Net;
using Todo.Service.Exceptions;

namespace Todo.API
{
    public class CustomExeptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExeptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {

                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception exception)
        {
            ApiRespones apiRespones = new();

            switch (exception)
            {
                case
                    TodoNotFoundException todoNotFoundException:
                    apiRespones.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespones.IsSuccess = false;
                    apiRespones.Message = todoNotFoundException.Message;
                    apiRespones.Result = null;
                    break;
                case
                    UserNotFoundException userNotFoundException:
                    apiRespones.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespones.IsSuccess = false;
                    apiRespones.Message = userNotFoundException.Message;
                    apiRespones.Result = null;
                    break;

                case
                    ArgumentException argumentException:
                    apiRespones.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespones.IsSuccess = false;
                    apiRespones.Message = argumentException.Message;
                    apiRespones.Result = null;
                    break;

                case
                    UnauthorizedAccessException unauthorizedAccessException:
                    apiRespones.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespones.IsSuccess = false;
                    apiRespones.Message = unauthorizedAccessException.Message;
                    apiRespones.Result = null;
                    break;

                case
                    Exception ex:
                    apiRespones.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    apiRespones.IsSuccess = false;
                    apiRespones.Message = ex.Message;
                    apiRespones.Result = null;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = apiRespones.StatusCode;

            return context.Response.WriteAsJsonAsync(apiRespones);

        }
    }
}
