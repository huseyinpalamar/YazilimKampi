using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            Console.WriteLine(ogrenciler.Count);

            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            Console.WriteLine(sehirler.Const);
            sehirler.Add(1,"istanbul");
            sehirler.Add(2,"Ankara");
            sehirler.Add(3,"Bursa");
            sehirler.Add(4,"Çanakkale");

        }
    }
}
