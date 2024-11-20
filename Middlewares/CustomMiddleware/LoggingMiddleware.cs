namespace Middlewares.CustomMiddleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            Console.WriteLine("Handling request: "+ context.Request.Path);
            await _next(context);
            Console.WriteLine("Finished handling request.");
        }
    }
}
