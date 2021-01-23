using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T_k, T_v>

    {
        T_k[] keys;
        T_v[] values;

        public MyDictionary()
        {
            keys = new T_k[0];
            values = new T_v[0];

        }

        public void Add (T_k key, T_v value)
        {
            T_k[] tempKeys = keys;
            T_v[] tempValues = values;

            keys = new T_k[keys.Length + 1];
            values = new T_v[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[tempKeys.Length] = key;
            values[tempValues.Length] = value;
        }


        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key : " + keys[i]);
                Console.WriteLine("Value : " + values[i]);

            }
        }
        public void Clear()
        {
            keys = new T_k[0];
            values = new T_v[0];
            Console.WriteLine("--------------------------------");
        }


    }
}
