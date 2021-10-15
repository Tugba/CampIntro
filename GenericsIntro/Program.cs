using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
           // myDictionary.Add(1, "Ayşe");
           // myDictionary.Add(2, "Ali");
           // int elemansayi = myDictionary.Count;
           //Console.WriteLine(elemansayi);


            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tuğba");


        }
    }
}
