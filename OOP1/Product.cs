using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Bu tür class larda sadece özellik olur!! /entity
    {
        public int Id { get; set; }  // bir nesneyi diğerlerinden ayırt edebilmek veri tabaında kullanığmız bir numaradar.
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } // fiyat
        public int UnitsInStock { get; set; }// urun stok adedi


    }
}
