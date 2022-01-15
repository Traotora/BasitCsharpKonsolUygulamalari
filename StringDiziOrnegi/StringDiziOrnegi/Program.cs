using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDiziOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5] { "Tokat", "Erzincan", "Istanbul", "Eskisehir", "Amasya" };
            Array.Sort(sehirler); // Diziyi alfabetik olarak sıralayıp yeniden oluşturdu.
            foreach (string eleman in sehirler)
            {
                Console.WriteLine("{0}", eleman);
            }
            Console.WriteLine("Dizideki Eleman Sayısı: {0}", sehirler.Length); // Dizinin boyutuna/uzunluğuna bakıp kaç elemanlı olduğunu buldu.
            Console.ReadKey();
        }
    }
}
