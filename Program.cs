using FactsApi.Helpers;
using FactsApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IFactService, FactService>();
builder.Services.AddSingleton<IFileWriter, FileWriter>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();