using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            sehirler.Add("Sivas");
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            
            Console.WriteLine(sehirler.Count);
            MyList<string> isimler = new MyList<string>();
           
            Console.WriteLine(isimler.Count);

            foreach (var list in sehirler)
            {
                Console.WriteLine(list);
            }
           


        }
    }
}
class MyList<T> // Generic class.
{
    T[] _array; // koleksiyonlar arka bazda array yonetır.
    T[] _tempArray;  // geçici arrayım buna referans tuttruucam 
    public MyList()

    {
        
        _array = new T[0];  // eleman sayısı sıfırlandı.
    }
     
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length+1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length - 1] = item;
    }
   

    public int Count
    {
        get { return _array.Length; }
       
    }

}
