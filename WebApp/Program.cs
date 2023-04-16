namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
       
            // Regisre service
            builder.Services.AddTransient<IManagementCars, Car>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseMiddleware<IManagementCars>();
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }

        public static void HandleNames(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("");
                {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
                        //context.Response.ContentType = "text/html;charset=utf-8";
                    }
                };
            });
                

        }
        //public static void HandleNames(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("");
        //        app.Use(async (context, next) =>
        //        {
        //            foreach (var car in Garage.Cars)
        //            {
        //                await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
        //                await next();
        //                context.Response.ContentType = "text/html;charset=utf-8";
        //            }
        //        });
        //    }
        //        );

        //}

        public static void HandleEngines(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("");
                {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarEngine()}");
                        
                    }
                }
            }
                );

        }

        public static void HandleAges(IApplicationBuilder app)
        {
            app.Run(async context =>
            {

                await context.Response.WriteAsync("");
               {
                    foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarAge()}");
                     }
                }
            }
            );

        }

        //public static void HandleEngines(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("");
        //        app.Use(async (context, next) =>
        //        {
        //            foreach (var car in Garage.Cars)
        //            {
        //                await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarEngine()}");
        //                await next();
        //            }
        //        });
        //    }
        //        );

        //}

        //public static void HandleAges(IApplicationBuilder app)
        //{
        //    app.Run(async context =>
        //    {

        //        await context.Response.WriteAsync("");
        //        app.Use(async (context, next) =>
        //        {
        //            foreach (var car in Garage.Cars)
        //            {
        //                await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarAge()}");
        //                await next();
        //            }
        //        });
        //    }
        //    );

        //}

        ////public Task Invoke(HttpContext httpContext, IApplicationBuilder app)
        ////{
        ////    app.UseExceptionHandler(error =>
        ////    {
        ////        error.Run(async context =>
        ////        {
        ////            await context.Response.WriteAsync("from Exception Handler middleware");
        ////        });
        ////    });
        ////    return next (httpContext);
        ////}

        ////private Task next(HttpContext httpContext)
        ////{
        ////    throw new NotImplementedException();
        ////}
    }
    
}