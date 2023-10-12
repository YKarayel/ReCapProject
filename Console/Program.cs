using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;

CarManager carManager = new CarManager(new CarDal());


foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Id.ToString() + car.BrandId + car.ColorId+ car.Description+ car.DailyPrice+ car.Description);
}

Console.WriteLine(carManager.GetById(2));