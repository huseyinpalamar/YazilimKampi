using System;

namespace ReferanceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //person1.FirstName = "Hüseyin";
          
            //Person person2 = new Person();
            //person2.FirstName = "Ali";

            //person1 = person2;
            //person2.FirstName = "İlkay";

            //Console.WriteLine(person1.FirstName);
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Ali";
            customer.CereditCardNumber = "4545";
            Person person3 = customer;
            person3.FirstName = "Mahmut";

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(((Customer)person3).CereditCardNumber); // boxing yapma
            Employee employee = new Employee();
            employee.EmployeeNumber = 11111;
            employee.FirstName = "Murat";
            

            

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);
        }
    }
}
