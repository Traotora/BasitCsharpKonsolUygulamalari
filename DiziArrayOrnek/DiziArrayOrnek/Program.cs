using System;

namespace DiziArrayOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsolda dizi örneği. -trao
            int[,] notlar= new int[3, 2] { { 50, 60 }, { 70, 80 }, { 40, 30 } };
            Console.WriteLine("1. Satır 1. Eleman: {0}", notlar[0, 0]);
            Console.WriteLine("2. Satır 2. Eleman: {0}", notlar[1, 1]);
            Console.WriteLine("3. Satır 1. Eleman: {0}", notlar[2, 0]);
            Console.ReadKey();
        }
    }
}
