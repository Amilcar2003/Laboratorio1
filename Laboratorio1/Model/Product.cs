using System.Collections.Generic;

namespace Laboratorio1.Model
{
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> products = new List<Product>();

    }
}
