using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using new_wr_api.Data;
using new_wr_api.Service;
using new_wr_api.Service.BaoCaoBieuMau;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Register the DatabaseContext with the dependency injection container
services.AddDbContext<DatabaseContext>();

services.AddAutoMapper(typeof(Program));

services.AddScoped<IAuthService, AuthService>();
services.AddScoped<UserService>();
services.AddScoped<RoleService>();
services.AddScoped<DashboardService>();
services.AddScoped<RoleDashboardService>();
services.AddScoped<UserDashboardService>();
services.AddScoped<PermissionService>();

//Other Service
services.AddScoped<CT_ThongTinService>();
services.AddScoped<CT_ThongSoService>();
services.AddScoped<CT_LoaiService>();
services.AddScoped<CT_HangMucService>();

services.AddScoped<GP_ThongTinService>();
services.AddScoped<GP_LoaiService>();
services.AddScoped<GP_TCQService>();
services.AddScoped<TCQ_ThongTinService>();

services.AddScoped<TangChuaNuocService>();
services.AddScoped<ToChucCaNhanService>();

services.AddScoped<SongService>();
services.AddScoped<LuuVucSongService>();
services.AddScoped<TieuVungLuuVucService>();
services.AddScoped<DonViHCService>();

services.AddScoped<BieuMauMotService>();
services.AddScoped<BieuMauHaiService>();
services.AddScoped<BieuMauBaService>();
services.AddScoped<BieuMauBonService>();
services.AddScoped<BieuMauNamService>();
services.AddScoped<BieuMauSauService>();
services.AddScoped<BieuMauBayService>();
services.AddScoped<BieuMauTamService>();
services.AddScoped<BieuMauChinService>();
services.AddScoped<BieuMauMuoiService>();
services.AddScoped<BieuMauMuoiMotService>();
services.AddScoped<BieuMauMuoiHaiService>();
services.AddScoped<BieuMauMuoiBaService>();
services.AddScoped<BieuMauMuoiBonService>();
services.AddScoped<BieuMauMuoiNamService>();
services.AddScoped<BieuMauMuoiSauService>();
services.AddScoped<BieuMauMuoiBayService>();
services.AddScoped<BieuMauMuoiTamService>();
services.AddScoped<BieuMauMuoiChinService>();
services.AddScoped<BieuMauHaiMotService>();
services.AddScoped<BieuMauHaiHaiService>();
services.AddScoped<BieuMauHaiBaService>();
services.AddScoped<BieuMauHaiTuService>();
services.AddScoped<BieuMauHaiLamService>();
services.AddScoped<GiamSatService>();


services.AddScoped<Tram_ThongTinService>();
services.AddScoped<NMua_TongLuongService>();
services.AddScoped<NM_SoLuongService>();
services.AddScoped<NM_TongLuongService>();


services.AddIdentity<AspNetUsers, AspNetRoles>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 1; // Set the minimum password length to 1 or any other value you prefer
})
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();

services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });



services.AddControllers();

services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WRQuangNgai API", Version = "v1" });
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "JWT Authorization header using the Bearer scheme. Example: \"{token}\"",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = JwtBearerDefaults.AuthenticationScheme
        }
    };
    c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { securityScheme, new string[] { } }
    });
});

// Add JWT authentication
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"] ?? ""));

services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = key
    };
});

// Add CORS policy
services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000", "https://tnmt.vercel.app")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "WRQuangNgai API");
    });
}

//Add CORS policy
app.UseCors();

app.UseSwagger();

//app.UseHttpsRedirection();

//app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
