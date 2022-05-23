using System;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();            
            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(2, "Mehmet");
            myDictionary.Add(3, "Sadık");
            myDictionary.Add(4, "Emin");
            for (int i = 0; i < myDictionary.Keys.Length; i++)
            {
                Console.WriteLine(myDictionary.Keys[i]);
                Console.WriteLine(myDictionary.Values[i]);
            }
        }
    }
}
