using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 350;
            product1.UnitsInStock = 10;

        //PascalCase/camelCase    
         Product product2 = new Product {Id=2,CategoryId=2,ProductName="Sandalye",UnitPrice=100,UnitsInStock=2 };  // bu tarz kullanımda var

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);
            productManager.Add(product1);


            //productManager.Topla2(3,5);
            ////int sonuc = productManager.Topla2(5,3); değeri başka yerde kullanamıyoruz. void ile yazılmış bir metod
            //int sonuc = productManager.Topla(5, 9);// toplama işlemi sonucu int bir değere atanabilir ve bu değeri başka yerde kullanabilrim.

            //int carpimSonucu = (sonuc * 2);
            //Console.WriteLine(sonuc);
            //Console.WriteLine(carpimSonucu); // sonucu başka eyrlerde kullanabılmemı sağlıyor.
        }
    }
}
