using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2; //2-mobilya kategorisi 
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5, ProductName="Kalem",UnitPrice=35}; //5-kırtasiye kategorisi

            ProductManager productManager = new ProductManager(); //instance-örnek oluşturma
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
