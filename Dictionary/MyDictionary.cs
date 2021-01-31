using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,T>
    { 
        T[] _arrayT;
        K[] _arrayK;
        T[] tempValue;
        K[] tempKey;
        public MyDictionary()
        {
            _arrayT = new T[0];
            _arrayK = new K[0];
        }
        public void Add(K key ,T item)
        {
            tempKey = _arrayK;
            tempValue = _arrayT;
            _arrayT = new T[_arrayT.Length + 1];
            _arrayK = new K[_arrayK.Length + 1];
            for (int i = 0; i <tempValue.Length ; i++)
            {
                _arrayT[i] = tempValue[i];
            }
            for (int k = 0; k < tempKey.Length; k++)
            {
                _arrayK[k] = tempKey[k];
            }
            _arrayT[_arrayT.Length - 1] = item;
            _arrayK[_arrayK.Length - 1] = key;

            Console.WriteLine("Id : " + key + " Name : " + item);
        }
      

        public int Const
        {
            get { return _arrayT.Length; }
           
        }

    }
}
