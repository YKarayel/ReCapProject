using Business.Abstract;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Services, Businesses
builder.Services.AddSingleton<IBrandManager, BrandManager>();
builder.Services.AddSingleton<ICarManager, CarManager>();
builder.Services.AddSingleton<IColorManager, ColorManager>();
builder.Services.AddSingleton<ICustomerManager, CustomerManager>();
builder.Services.AddSingleton<IRentalManager, RentalManager>();
builder.Services.AddSingleton<IUserManager, UserManager>();

//Context, DataAccess
builder.Services.AddSingleton<IBrandDal, BrandDal>();
builder.Services.AddSingleton<ICarDal, CarDal>();
builder.Services.AddSingleton<IColorDal, ColorDal>();
builder.Services.AddSingleton<ICustomerDal, CustomerDal>();
builder.Services.AddSingleton<IRentalDal, RentalDal>();
builder.Services.AddSingleton<IUserDal, UserDal>(); 





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
