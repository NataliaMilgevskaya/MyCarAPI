using Microsoft.Extensions.DependencyInjection;

namespace MyCarAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Regisre service
            builder.Services.AddTransient<IManagementCars, Car>();
            

            var app = builder.Build();

            //app.UseMiddleware<IManagementCars>();
            //app.Map("/names", HandleNamesAsync);
            app.Map("/names", HandleNames);
            app.Map("/engines", HandleEngines);
            app.Map("/ages", HandleAges);

            app.Run(async context =>
            {
                var t = app.Services.GetService<IManagementCars>();
                foreach (var car in Garage.Cars)
                {
                    await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
                    await context.Response.WriteAsync($"\t Engine {car?.GetCarEngine()}");
                    await context.Response.WriteAsync($"\t Age {car?.GetCarAge()}");
                }


            });
            
            
            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        //public static async Task HandleNamesAsync(HttpContext context)
        //{
        //    foreach (var car in Garage.Cars)
        //    {
        //        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
        //    }
        //}
        public static void HandleNames(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("");
                app.Use(async (context, next) =>
                                {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
                        await next();
                    }
                });
            }
                );

        }

        public static void HandleEngines(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("");
                app.Use(async (context, next) =>
                {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarEngine()}");
                        await next();
                    }
                });
            }
                );

        }

        public static void HandleAges(IApplicationBuilder app)
        {
            app.Run(async context =>
            {

                await context.Response.WriteAsync("");
                app.Use(async (context, next) =>
                {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarAge()}");
                        await next();
                    }
                });
            }
            );

        }
        //public void Configure(IApplicationBuilder app)
        //{
        //    app.UseMiddleware<ManagementCarsMiddleware>();

        //    // other middleware registrations
        //}

    }
}
