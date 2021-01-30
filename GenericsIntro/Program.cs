using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler = new List<string>();
            Console.WriteLine(isimler.Count);     // count  eleman sayısı 

            MyList<int> sayilar = new MyList<int>();

        } 
        
    }   
}
