using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> myDictionary = new MyDictionary<int>();
            myDictionary.Add(50);
            myDictionary.Add(25);
            myDictionary.Add(257);
            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine(item);
            }
        }                        
        
    }                               
}                                   
                                    