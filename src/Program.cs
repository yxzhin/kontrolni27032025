using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kontrolni27032025_AleksejJuzin_II3
{
    internal class Program
    {

        // made by @yxzhin with <3
        // grupa A

        // 1. linearna funkcija poziva sebe samo jednom u svakom rekurzivnom pozivu, a nelinearna vise puta, sto dovodi do slozenog grananja u kodu.
        // 2. moguci problemi pri rekurziji moze biti prepunjavanje steka ili stack overflow, kada je rekurzija prevelika, takodje rekurzija u nekim slucajevima moze biti manje efikasna od iterativnih resenja, kao i to sto rekurzija moze biti teza za razumevanje.
        // 3. prevelika rekurzija moze dovesti do popunjavanja steka kada bazni slucaj ne radi i rekurzija se ne zaustavlja, to jest rekurzija se desava beskonacno.
        // 4. rekurzija moze biti manja od iterativnih resenja zbog troskova memorije koji nastaju pri rekurzivnom pozivu.
        // 5.

        //private static int duzinaNiza = 1;

        private static void greska(Int16 type_)
        {

            switch (type_)
            {

                case -1: Console.WriteLine("unesite validne vrednosti"); break;
                case -2: Console.WriteLine("vrednost mora biti veca od 0"); break;
                case -3: Console.WriteLine("vrednost mora biti u opsegu od 1 do 10"); break;

            }

        }

        private static int unesiDuzinuNiza(int n)
        {

            while (true)
            {

                Console.WriteLine($"unesite duzinu niza #{n}:");

                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {

                    greska(type_: -1);
                    continue;

                }

                if (odgovor <= 0)
                {

                    greska(type_: -2);
                    continue;

                }

                return odgovor;

            }

        }

        private static int[] unesiElementeNiza(int duzina, int n)
        {

            int[] brojevi = new int[duzina];

            for(int i = 0; i < duzina; i++)
            {

                while (true)
                {

                    Console.WriteLine($"unesite element #{i+1} niza #{n}:");

                    if (!int.TryParse(Console.ReadLine(), out int odgovor))
                    {

                        greska(type_: -1);
                        continue;

                    }

                    if(odgovor < 1 || odgovor > 10)
                    {

                        greska(type_: -3);
                        continue;

                    }

                    brojevi[i] = odgovor;

                    break;

                }

            }

            return brojevi;

        }

        private static int sumaKvadrataNeparnih(int[] brojevi, int n)
        {

            if (n == 0) return 0;

            int trenutni = brojevi[n - 1];

            if(n % 2 != 0)
            {

                return trenutni*trenutni + sumaKvadrataNeparnih(brojevi, n - 1);

            }

            return sumaKvadrataNeparnih(brojevi, n - 1);

        }

        private static void prikaziRezultate(int[] brojevi, int sumaKvadrata, int n)
        {

            Console.WriteLine($"rezultate za niz #{n}:");
            Console.WriteLine($"svi uneti brojevi: {string.Join(", ", brojevi)}");
            Console.WriteLine($"suma kvadrata neparnih: {sumaKvadrata}");

        }

        public static void Main(string[] args)
        {

            int duzina1 = unesiDuzinuNiza(n:1);
            int duzina2 = unesiDuzinuNiza(n:2);

            int[] brojevi1 = unesiElementeNiza(duzina1, n:1);
            int[] brojevi2 = unesiElementeNiza(duzina2, n:2);

            int sumaKvadrata1 = sumaKvadrataNeparnih(brojevi1, duzina1);
            int sumaKvadrata2 = sumaKvadrataNeparnih(brojevi2, duzina2);

            prikaziRezultate(brojevi1, sumaKvadrata1, n:1);
            prikaziRezultate(brojevi2, sumaKvadrata2, n:2);

            Console.ReadLine();

        }
    }
}
