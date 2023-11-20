var webApplicationBuilder = WebApplication.CreateBuilder();

webApplicationBuilder.Services.AddCors(options => options.AddDefaultPolicy(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

webApplicationBuilder.Services.AddAuthentication();

webApplicationBuilder.Services.AddAuthorization();

webApplicationBuilder.Services.AddControllers();

var webApplication = webApplicationBuilder.Build();

webApplication.UseHttpsRedirection();

webApplication.UseCors();

webApplication.UseAuthentication();

webApplication.UseAuthorization();

webApplication.MapControllers();

webApplication.Run();
