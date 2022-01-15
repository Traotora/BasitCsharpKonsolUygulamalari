using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[5] { "Tokat" , "Erzincan", "Istanbul", "Eskisehir","Amasya" };
            foreach(string eleman in sehirler)
            {
                Console.WriteLine("{0}", eleman);
             }
            Console.ReadKey();
        }
    }
}
