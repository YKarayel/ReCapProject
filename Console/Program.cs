using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;

CarManager carManager = new CarManager(new InMemoryCarDal());

carManager.Add(new Entities.Concreate.Car
{
    Id = 6,
    BrandId = 1,
    ColorId = 3,
    DailyPrice = 125000,
    ModelYear= "2020",
    Description= "Renault"
});

carManager.Delete(6);
carManager.GetAll();
carManager.Update(new Entities.Concreate.Car
{
    Id = 4,
    BrandId = 4,
    ColorId = 3,
    DailyPrice = 299999,
    Description = "Audi",
    ModelYear = "2020"
});

carManager.GetById(4);
