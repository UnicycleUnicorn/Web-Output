namespace WebOutput;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        _ = builder.Services.AddControllers();
        //_ = builder.Services.AddAuthentication().AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

        WebApplication app = builder.Build();

        // Configure the HTTP request pipeline.

        _ = app.UseHttpsRedirection();

        //_ = app.UseAuthentication();
        // _ = app.UseAuthorization();

        _ = app.MapControllers();

        app.Run();
    }
}
