using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;

//Car();


//User();

Rent();

static void Get()
{
    var carManager = new CarManager(new CarDal());


    foreach (var car in carManager.GetAll().Data)
    {
        Console.WriteLine(car.Id.ToString() + car.BrandId + car.ColorId + car.Description + car.DailyPrice + car.Description);
    }

    Console.WriteLine(carManager.GetById(2));
}

static void User()
{
    var userManager = new UserManager(new UserDal());

    Console.WriteLine(userManager.Add(new User { Email = "asdf@gmail.com", CustomerId = 1, FirstName = "Mehmet", LastName = "Karayel", Password = "Password12*" }).Message);
    Console.WriteLine(userManager.GetById(1));



    var userlist = userManager.GetAll().Data;
    foreach (var user in userlist)
        Console.WriteLine($"{user.Id}  {user.FirstName}  {user.LastName}  {user.CustomerId}  {user.Email}  {user.Password}");
}

static void Rent()
{
    var rental = new RentalManager(new RentalDal());
    Console.WriteLine(rental.Add(new Rental { CarId = 1, CustormerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now }).Message);
}