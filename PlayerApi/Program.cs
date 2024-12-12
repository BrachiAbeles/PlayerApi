var builder = WebApplication.CreateBuilder(args);

// הוספת שירותי CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // כתובת ה-React שלך
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// שימוש ב-CORS
app.UseCors("AllowReactApp");

app.UseAuthorization();
app.MapControllers();

app.Run();
