using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {

            Console.WriteLine(customer.Tc+"Nolu kişi eklendi..");

        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Tc + "Nolu Güncellendi..");


        }
        public void Delete(Customer customer)
        {

            Console.WriteLine(customer.Tc + "Nolu kişi Silindi..");

        }
    }
}
