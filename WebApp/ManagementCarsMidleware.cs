namespace WebApp
{
    public class ManagementCarsMiddleware
    {
        public RequestDelegate next;
        public IManagementCars cars;

        public ManagementCarsMiddleware(RequestDelegate next, IManagementCars cars)
        {
            this.next = next;
            this.cars = cars;
        }

        public async Task InvokeAsync(HttpContext context, IManagementCars cars)
        {
            foreach (var car in Garage.Cars)
            {
                await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
                await next(context);
                await context.Response.WriteAsync($"\t Engine {car?.GetCarEngine()}");
                await next(context);
                await context.Response.WriteAsync($"\t Age {car?.GetCarAge()}");
                await next(context);
            }
        }
    }

}
