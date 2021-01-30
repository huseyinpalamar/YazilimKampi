using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        // constructor
        public MyList()
        {
            items = new T[0];  // new lediğin anda eleman oalrk 0 atar
        }
        public void Add(T item)
        {
            T[] tempArray = items; // burda items taki değerlerimi geçici bir referans nuamrsaında tutarım.
            items = new T[items.Length+1];  //items.lenght=eleman sayısı bir arttır. ama bir poblem var?

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray e atadıgım emanet elemanları sırası ıle uzerıme alıyorum.

               

            }
            items[items.Length - 1] = item;
        }

    }
}
