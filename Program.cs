using System;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                MyDictionary<string> urunler = new MyDictionary<string>();
                urunler.Add("Bardak");
                urunler.Add("Kase");
                Console.WriteLine(urunler.Length);
                urunler.Add("Tabak");
                Console.WriteLine(urunler.Length);

            
        }
    }
}
