using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Kiir(int[] t , string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}, ");
            }
        }
        

        static int Osszegez ( int[] t)
        {
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg = t[i];
                }

            }
            return osszeg;
        }


        static void kiir_eredmeny(int roka_libainak_sulya)
        {

        }

        static void Main(string[] args)
        {

            int[] libak = { 1, 5, 2, 3, 4 };
            Kiir(libak,"libak sullyai");
            int hany_kilo_liba_ehet_meg_a_roka = Osszegez(libak);
            Console.WriteLine("gomb");
            Console.ReadKey();

        }
    }
}
