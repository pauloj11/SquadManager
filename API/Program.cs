using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options => 
options.AddPolicy("MyPolicy", builder => 
builder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()));
builder.Services.AddSwaggerGen(x =>
{
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    x.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
