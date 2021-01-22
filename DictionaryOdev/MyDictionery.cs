using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionery<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionery()
        {
            keys = new K[0];
            values = new V[0];
        }
            
            
        public void Add(K itemK, V itemV)
            
        {
            K[] tempArayk = keys;
            V[] tempArayv = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int k = 0; k < tempArayk.Length; k++)
            {
                keys[k] = tempArayk[k];
                values[k] = tempArayv[k];
            }
           keys[keys.Length - 1] =  itemK;
           values[values.Length - 1] = itemV;
        }
        
       
        public int Length
        {
            get { return keys.Length; }
        }

        public K[] Keys
        {
            get { return keys; }
        }

        public V[] Values
        {
            get { return values; }
        }


    }
}
