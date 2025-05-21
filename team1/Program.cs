using FluentValidation.AspNetCore;
using team1.DTOs.Validators;
using team1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// FluentValidation (nuget terminal: Install-Package FluentValidation.AspNetCore)
builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateProductDtoValidator>());

// EmailService
builder.Services.AddSingleton(new EmailService("smtp.example.com", 587, "your-email@example.com", "your-email-password"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
