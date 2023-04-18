namespace WebApp
{
    public delegate void MyDelegate(string msg);
    public partial class Program
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

            //app.UseMiddleware<CounterMiddleware>;

            printString myDelegate = Console.WriteLine;
            myDelegate("Choose color");
            static void PrintGreen(string input)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(input);
            }

            static void PrintOrange(string input)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(input);
            }

            myDelegate = PrintGreen;
            myDelegate("This text should be green.");

            myDelegate = PrintOrange;
            myDelegate("This text should be orange.");


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

        delegate void printString(string input);




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


        public Task Invoke(HttpContext httpContext, IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    await context.Response.WriteAsync("from Exception Handler middleware");
                });
            });
            return next(httpContext);
        }

        private Task next(HttpContext httpContext)
        {
            throw new NotImplementedException();
        }
    }

}