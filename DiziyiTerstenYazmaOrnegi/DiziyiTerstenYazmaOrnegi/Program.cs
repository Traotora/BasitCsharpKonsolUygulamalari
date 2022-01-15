using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziyiTerstenYazmaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5]{1, 2, 3, 4, 5};
            Array.Reverse(sayilar); // Reverse olmasa yukarıdan aşağıya 1-2-3-4-5 diye sıralanırdı.
            foreach(int eleman in sayilar)
            {
                Console.WriteLine("{0}", eleman);
            }
            Console.ReadKey();
        }
    }
}
