
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TouristСenterLibrary;
using WebServerAsp.Repositories;
using WebServerAsp.Controllers;
using WebServerAsp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(o=>o.AddDefaultPolicy(b=>b.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000").AllowCredentials()));
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(o=>o.UseNpgsql(connection));

builder.Services.AddSignalR();

builder.Services.AddTransient<IUserRepository, UserService>();
builder.Services.AddTransient<ITypesAppealRepository, TypesAppealService>();
builder.Services.AddTransient<IPsyhologistRepository, PsyhologistService>();
builder.Services.AddTransient<IAnswerReposiroty, AnswerService>();
builder.Services.AddTransient<IAppealRepository, AppealService>();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o => 
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = AuthOptions.ISSUER,
        ValidateAudience = true,
        ValidAudience = AuthOptions.AUDIENCE,
        ValidateLifetime = true,
        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
        ValidateIssuerSigningKey = true
    };
});

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    context.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:3000");
   
//    ////if(context.Request.Method == HttpMethods.Options)
//    ////{
//    //    context.Response.StatusCode = 200;
//    //}  
//    await next(context);
//});

app.UseCors();
app.UseWebSockets();
app.UseRouting();
app.UseAuthorization().UseAuthentication();
app.UseEndpoints(e => e.MapControllers());

app.Run();
public class AuthOptions
{
    public const string ISSUER = "ServerPsixCenter"; // �������� ������
    public const string AUDIENCE = "ClientPsixCenter"; // ����������� ������
    const string KEY = "2292779d8d66ef1a6de3a02eb409efa9932d9cdb";   // ���� ��� ����������
    public static readonly SigningCredentials SigningCredentials = new(GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(KEY));
}
