using System;
using System.Linq;

namespace karakter_tersten_yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tersten yazdırılacak ifadeyi giriniz : ");
            string ifade = Console.ReadLine();
            TerstenYazdir(ifade);
            
        }

        static void TerstenYazdir(string ifade)
        {
            string[] stringDizi = ifade.Split(' ');

            for (int i = 0; i < stringDizi.Length; i++)
            {
                char[] charDizi = stringDizi[i].ToCharArray();
                Array.Reverse(charDizi);
                string kelime = new string(charDizi);
                Console.Write(kelime + " ");
            }

        }
    }
}
