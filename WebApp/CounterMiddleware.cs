namespace WebApp
{
    public partial class Program
    {
        public class CounterMiddleware 
        {
            RequestDelegate next;
            int i = 0;
            public CounterMiddleware(RequestDelegate next)
            {
                this.next = next;
            }
            public async Task InvokeAsynk(HttpContext httpContext, RequestDelegate next)
            {
                i++;
                httpContext.Response.ContentType = "text/html;charset=utf-8";
                await httpContext.Response.WriteAsync($"");
            }
        }







    }

}