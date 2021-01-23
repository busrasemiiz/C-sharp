using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> plakalar = new MyDictionary<string, int>();
            plakalar.Add("Samsun", 55);
            plakalar.Add("Eskişehir", 26);
            plakalar.Add("İstanbul", 34);
            plakalar.Add("Ankara", 06);

            plakalar.Print();
            plakalar.Clear();
            plakalar.Add("Trabzon", 61);
            plakalar.Print();
        }
    }
}
