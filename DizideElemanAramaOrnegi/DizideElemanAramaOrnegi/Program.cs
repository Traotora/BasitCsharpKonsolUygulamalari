using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizideElemanAramaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            // IndexOf ve LastIndexOf'un nasıl işlediğini göreceğiz.
            string[] UyeIsimleri = new string[6] { "Ali Yaşar", "Sadesu Deli", "Mert Yılmaz", "Kartal Kara", "Gülnur Elibol", "Emel Tatlıcı" };
            Console.Write(Array.IndexOf(UyeIsimleri, "Gülnur Elibol")); // Baştan 4. sırada olduğunu belirtir.
                                                                          //Saymaya 0'dan başladı. Buna dikkat edin.

            //Console.Write(Array.LastIndexOf(UyeIsimleri, "Gülnur Elibol")); // IndexOf'tan tek farkı aramaya sondan başlaması.
                                                                            // Yani LastIndexOf'da 4. sırada bulacak.
            Console.ReadKey();
        }
    }
}
