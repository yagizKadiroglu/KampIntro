using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Sozluk = new Dictionary<string, string>();
            Console.WriteLine(Sozluk.Count);

            MyDictionary<string, string> Sozluk1 = new MyDictionary<string, string>();
            Sozluk1.Add("Lale", "Çiçek");
            Sozluk1.Add("Lale","Çiçek");
            Console.WriteLine(Sozluk1.Count);
        }
    }
}
