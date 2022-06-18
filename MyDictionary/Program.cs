using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> adYas = new MyDictionary<string, int>();
            adYas.Add("Ali", 32);
            Console.WriteLine(adYas.Count);
            Console.WriteLine(adYas.Keys);
            Console.WriteLine(adYas.Values);
        }


    }
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TKey[] keyTemp;
        TValue[] values;
        TValue[] valueTemp;


        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            keyTemp = keys;
            valueTemp = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < valueTemp.Length; i++)
            {
                values[i] = valueTemp[i];
                keys[i] = keyTemp[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return values.Length; }
        }

        public TKey[] Keys
        {
            get { return keys; }
        }
        public TValue[] Values
        {
            get { return values; }
        }

    }
}
