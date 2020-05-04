using Laboratorio1.Model;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            User.users.Add(new User() { Username = "", Password = "", Role = "admin" });
            User.users.Add(new User() { Username = "juan", Password = "juan", Role = "employee" });
            Product.products.Add(new Product() { Name = "Manzana", Price = 60, Stock = 100 });
            Product.products.Add(new Product() { Name = "Melocoton", Price = 50, Stock = 100 });
            new Login().menu();
        }
    }
}
