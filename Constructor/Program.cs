using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Hüseyin","palamar") ; // parametre kullanım tarzı
            
            Customer customer2 = new Customer();
            customer2.Id = 1;

            Customer customer3 = new Customer() { Id = 1, FirstName = "Ahmet",LastName= "palamar" };
            

            Console.WriteLine(customer.FirstName);
        }
    }
}

