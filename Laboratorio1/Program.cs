using Laboratorio1.Model;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            User.users.Add(new User() { Username = "", Password = "", Role = "admin" });
            User.users.Add(new User() { Username = "amilcar", Password = "amilcar", Role = "employee" });
            Product.products.Add(new Product() { Name = "Computadora", Price = 6000, Stock = 100 });
            Product.products.Add(new Product() { Name = "PS4", Price = 4000, Stock = 100 });
            Product.products.Add(new Product() { Name = "Videojuegos", Price = 500, Stock = 100 });
            new Login().menu();
        }
    }
}
