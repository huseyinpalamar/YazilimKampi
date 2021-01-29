using System;

namespace ClassMetoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Egemen";
            customer1.Surname = "Kurtuldu";
            customer1.Tc="1548877755";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ahmet";
            customer2.Surname = "Atasoy";
            customer2.Tc = "487857425544";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer2);

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers) 
            {

                Console.WriteLine(customer.Name+" "+customer.Surname+" :"+customer.Tc);
            }
        
        
        }


    }
}
