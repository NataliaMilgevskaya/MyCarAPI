namespace MyCarAPI
{
    public class ImportantNotes
    {
    }
}
/*
            app.UseMiddleware<IManagementCars>();
            app.UseMiddleware<ManagementCarsMiddleware>();

            app.Map("/car_names", HandleNames);
            app.Map("/car_engines", HandleEngines);
            app.Map("/car_ages", HandleAges);

            /*app.Run(async (context, next) =>
            {
               foreach (var car in Garage.Cars)
                    {
                        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
                        await next();
                        await context.Response.WriteAsync($"\t Engine {car?.GetCarEngine()}");
                        await next();
                        await context.Response.WriteAsync($"\t Age {car?.GetCarAge()}");
                        await next();
                    }
                
            });*/


//////////app.Use(async (context, next) =>
//////////{
//////////    foreach (var car in Garage.Cars)
//////////    {
//////////        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
//////////        next();
//////////        await context.Response.WriteAsync($"\t Age {car?.GetCarAge()}");
//////////    }
//////////});

//////////app.Use(async (context, next) =>
//////////{
//////////    foreach (var car in Garage.Cars)
//////////    {
//////////        await context.Response.WriteAsync($"\t Engine {car?.GetCarEngine()}");
//////////    }
/////});
////app.Run(async context =>
////{
////    await context.Response.WriteAsync("");
////    app.Run(async (context, next) =>

////    foreach (var car in Garage.Cars)
////    {
////        await context.Response.WriteAsync($"\n \n Car \t{car?.GetCarName()}");
////        await context.Response.WriteAsync($"\t Engine {car?.GetCarEngine()}");
////        await context.Response.WriteAsync($"\t Age {car?.GetCarAge()}");
////    }
////});