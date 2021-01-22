using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionery<int,string> numara = new MyDictionery<int,string>();
            numara.Add (1,"AHMET");
            numara.Add(2,"MEHMET");
            numara.Add(3, "AYŞE");
            numara.Add(4, "FATMA");



            for (int i = 0; i < numara.Keys.Length; i++)
                Console.WriteLine("Sıra No:"+numara.Keys[i]+"        İsim:"+ numara.Values[i]);

        }
    }
}
