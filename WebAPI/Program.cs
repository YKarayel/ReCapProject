using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concreate;
using Business.DependecyResolvers.Autofac;
using Core.DependecyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using DataAccess.Abstract;
using DataAccess.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBussinessModule());
    });

builder.Services.AddDependecyResolvers(new ICoreModule[]
{
	new CoreModule()
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
