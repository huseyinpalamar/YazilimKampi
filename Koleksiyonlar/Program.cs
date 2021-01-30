using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string[] isimler = new string[] {"Ali","Egemen","İlkay" };
        //    Console.WriteLine(isimler[0]);
        //    Console.WriteLine(isimler[1]);
        //    Console.WriteLine(isimler[2]);
        //    //isimler[3] = "Mahmut";  patladı!!!! Dizilere sonradan eleman ekleyemzesin!!
        //    // Console.WriteLine(isimler[3]);
        //    isimler = new string[4];
        //    isimler[3] = "Mahmyut";
        //    Console.WriteLine(isimler[3]);
        //    Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Ali","Mahmut" };
            isimler2.Add("Egemen");
            isimler2.Add("Salih");
            isimler2.Add("Furkan");
            
            

            foreach (string isimlerz in isimler2)
            {
                Console.WriteLine(isimlerz);
            }
        }
    }
}
