using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CetegoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CetegoryId = 4;
            product2.ProductName = "kalem";
            product2.UnitPrice = 50;
            product2.UnitsInStock = 2;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            Console.WriteLine(product1.ProductName);
          
        }
    }
}
