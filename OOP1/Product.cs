using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        public int Id { get; set; } //primary key

        public int CategoryId { get; set; } //foreign key-referans anahtarları- hangi kategoriye dahil olduğu
        public string ProductName { get; set; } //ürün adı
        public double UnitPrice { get; set; } //birim fiyatı
        public int UnitsInStock { get; set; } //Stok adedi


    }
}
