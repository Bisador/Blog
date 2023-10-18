using Application;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.OpenApi.Models; 

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container. 
            AddServices(builder);
             
            var app = builder.Build(); 
            Configurations(app, builder);

            // Configure the HTTP request pipeline. 
            //app.MapGet("/api/about", (string name) => Results.Ok("Hi "+ name)).Produces(StatusCodes.Status200OK);
            app.UseHttpsRedirection(); 
            app.UseAuthorization(); 
            app.MapControllers(); 
            app.Run();

        }

        private static void AddServices(WebApplicationBuilder builder)
        {

            builder.Services.RegisterApplicationServices();
            builder.Services.AddControllers();

            var presentationAssembly = typeof(Presentation.Controllers.ArticleController).Assembly; 
            builder.Services.AddControllers().AddApplicationPart(presentationAssembly);
             

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddPersistence(builder.Configuration.GetConnectionString("DefaultConnection"));
             
            #region Swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.IncludeXmlComments(string.Format(@"{0}\CMS.xml", AppDomain.CurrentDomain.BaseDirectory));
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CMS",
                });
            });
            #endregion

            
        }

        private static void Configurations(WebApplication app, WebApplicationBuilder builder)
        { 
            #region Swagger
            if (app.Environment.IsDevelopment())
            {
                // Enable middleware to serve generated Swagger as a JSON endpoint.
                app.UseSwagger();

                // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
                // specifying the Swagger JSON endpoint.
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CMS");
                });
            } 
            #endregion
        }
    }
}