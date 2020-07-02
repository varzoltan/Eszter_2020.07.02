using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._07._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hozzunk létre 2 db 20 elemű tömböt. Az egyik tömbelem neve legyen paros, a masik paratlan. 
            //Generáljunk véletlen egész számokat 1 - 100 között úgy, hogy a páros véletlen számot a paros tömbbe, a páratlan véletlen számot a paratlan tömbbe tegyük bele. Az így kapott két tömbben lévő véletlenszámokat (külön-külön) írjuk ki a konzolra, 
            //de csak azokat az elemeket, amelyek nem tartalmaznak 0-át!
            //1.lépés: létrehozzuk a tömböket
            int[] paros = new int[20]; //Kész a páros "üres"
            int[] paratlan = new int[20];
            //2.lépés: Vélellen szám inicializálása
            Random veletelen = new Random();
            //3.lépés: most kezdünk hozzá a feladat megoldádásoz.
            //int szam = veletelen.Next(1, 101);
            int i = 5;
            for (int j = 0; j < 20; j++)
            {
                int szam = veletelen.Next(1, 101);
                if (szam % 2 == 0)
                {
                    paros[j] = szam;
                }
                else
                {
                    paratlan[j] = szam;
                }
            }

            //Írjuk ki mindkét tömböt a konzolra
            for (int j = 0; j < 20; j++)
            {
                if (paros[j] != 0)
                {
                    Console.Write($"{paros[j]} ");
                }               
            }
            Console.WriteLine();
            for (int j = 0; j < 20; j++)
            {
                if (paratlan[j] != 0)
                {
                    Console.Write($"{paratlan[j]} ");
                }             
            }

            //Írjunk olyan programot, amely addig kér be egész számokat a billentyűzetről, 
            //amíg azok összege meg nem haladja a 100-at. 
            //Megoldás hátultesztelős ciklussal
            int ujszam = 0;
            do
            {
                //megszámlálás törvényét fogjuk használni a feladatmegoldáshoz
                Console.Write($"Adjon meg egy számot: ");
                int szam1 = int.Parse(Console.ReadLine());
                ujszam = ujszam + szam1;
            } while (ujszam < 100);

            Console.ReadKey();
        }
    }
}
